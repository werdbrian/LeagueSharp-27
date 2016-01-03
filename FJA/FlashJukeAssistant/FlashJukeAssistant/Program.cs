using LeagueSharp;
using SharpDX;
using LeagueSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using FlashJukeAssistant;

namespace FlashJukeAssistant
{
    class Program
    {
        public static Vector3 maximumFlashPos = new Vector3();
        public static Vector3 expectedFlashPos = new Vector3();
        public static float lastWardTime = -60.0f;
        public static float lastFlashTime = -60.0f;
        public const int flashRange = 400;
        public static float delayTime = 0.1f;
        public static int closestFlashSpot = 0;
        public static int inCircleRange = 5;
        public static int thick = 1;
        public static bool shouldBeFlashing = false;
        public static bool mustCheckForWards = true; //ally wards
        private static Menu Config;
        private static SpellSlot flash = ObjectManager.Player.GetSpellSlot("SummonerFlash");
        private static SpellSlot recall = SpellSlot.Recall;
        public static List<FlashSpot> Spots = new List<FlashSpot>();
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnGameLoad;
        }
        private static void OnGameLoad(EventArgs args)
        {
            Drawing.OnDraw += OnDraw;
            Game.OnUpdate += OnGameUpdate;
            //setupCoords();
            Config = new Menu("Flash Juke Assistant", "Flash Juke Assistant", true);
            Config.AddItem(new MenuItem("key", "Keybind: ")).SetValue(new KeyBind((byte)'T', KeyBindType.Press));
            Config.AddItem(new MenuItem("ward", "Use Wards: ")).SetValue(true);
            Config.AddItem(new MenuItem("recall", "Use Recall: ")).SetValue(true);
            /* -----DEVELOPMENT-----
            Config.AddItem(new MenuItem("create", "Create Spot Key: ")).SetValue(new KeyBind((byte)'a', KeyBindType.Press));
            Config.AddItem(new MenuItem("export", "Export Key: ")).SetValue(new KeyBind((byte)'e', KeyBindType.Press));
            Config.AddItem(new MenuItem("delete", "Delete Key: ")).SetValue(new KeyBind((byte)'d', KeyBindType.Press));
            Config.Item("create").ValueChanged += CreateSpot;
            Config.Item("export").ValueChanged += Export;
            Config.Item("delete").ValueChanged += DeleteSpot;*/   
            Config.Item("key").ValueChanged += KeyChanged;
            Config.AddToMainMenu();
            fillSpots();
        }
        private static void KeyChanged(object sender, OnValueChangeEventArgs e)
        {
            if (!((MenuItem)sender).GetValue<KeyBind>().Active)
            {
                shouldBeFlashing = true;
            }
            else
            {
                shouldBeFlashing = false;
            }
        }
        private static void CreateSpot(object sender, OnValueChangeEventArgs e)
        {
            if (((MenuItem)sender).GetValue<KeyBind>().Active) { return; }
            Spots.Add(new FlashSpot(ObjectManager.Player.Position, maximumFlashPos, expectedFlashPos));
        }
        private static void DeleteSpot(object sender, OnValueChangeEventArgs e)
        {
            if (((MenuItem)sender).GetValue<KeyBind>().Active) { return; }
            Spots.RemoveAt(closestFlashSpot);
        }
        private static void Export(object sender, OnValueChangeEventArgs e)
        {
            if (((MenuItem)sender).GetValue<KeyBind>().Active) { return; }
            string s = "Spots=new List<FlashSpot>{";
            foreach (FlashSpot spot in Spots)
            {
                s += spot.getConstructor() + ",";
            }
            s += "};";
            Console.WriteLine(s);
        }
        private static void OnGameUpdate(EventArgs args)
        {
            findClosest();
            if (closestFlashSpot != -1 && shouldBeFlashing && someSpellReady(Spots[closestFlashSpot].start))
            {
                ObjectManager.Player.IssueOrder(GameObjectOrder.MoveTo, Spots[closestFlashSpot].start);
                if (shouldBeFlashing && ObjectManager.Player.Position.Distance(Spots[closestFlashSpot].start, true) < inCircleRange)
                {
                    doTheFlash();
                    shouldBeFlashing = false;
                }
            }
            else if (shouldBeFlashing)
            {
                ObjectManager.Player.IssueOrder(GameObjectOrder.MoveTo, Game.CursorPos);
            }
        }
        private static float pathLength(Vector3 pos)
        {
            var path = ObjectManager.Player.GetPath(pos).ToArray();
            float length = 0;
            for (int i = 1; i < path.Length; i++)
            {
                length += path[i].Distance(path[i - 1]);
            }
            return length;
        }
        private static bool willBeAbleToCastOnArrival(SpellSlot spellSlot, Vector3 pos)
        {
            var spell = ObjectManager.Player.Spellbook.GetSpell(spellSlot);
            var cd = (spell.CooldownExpires) - Game.Time;
            var mana = spell.ManaCost;
            var arrivalTime = pathLength(pos) / ObjectManager.Player.MoveSpeed;
            if (arrivalTime >= cd && spell.State != SpellState.Surpressed && ObjectManager.Player.GetSpell(spellSlot).Level > 0 && ObjectManager.Player.Mana > spell.ManaCost)
            {
                return true;
            }
            return false;
        }
        public static void doTheFlash()
        {
            if (ObjectManager.Player.ChampionName == "Shaco" && willBeAbleToCastOnArrival(SpellSlot.Q, Spots[closestFlashSpot].start))
            {
                ObjectManager.Player.Spellbook.CastSpell(SpellSlot.Q, Spots[closestFlashSpot].target);
            }
            else
            {
                ObjectManager.Player.Spellbook.CastSpell(flash, Spots[closestFlashSpot].target);
            }

            ObjectManager.Player.IssueOrder(GameObjectOrder.MoveTo, Spots[closestFlashSpot].end);
            if (Config.Item("recall").GetValue<bool>())
            {
                ObjectManager.Player.Spellbook.CastSpell(recall);
            }
        }
        private static Obj_AI_Turret getClosestTurret(Vector3 pos)
        {
            var minions = ObjectManager.Get<Obj_AI_Turret>().ToList();
            Obj_AI_Turret closestMinion = new Obj_AI_Turret();
            float closestDistSq = float.PositiveInfinity;
            foreach (var minion in minions)
            {
                if (Vector3.Distance(pos, minion.Position) < closestDistSq)
                {
                    closestDistSq = Vector3.Distance(pos, minion.Position);
                    closestMinion = minion;
                }
            }
            return closestMinion;
        }
        private static void OnDraw(EventArgs args)
        {
            /* -----DEVELOPMENT-----
            maximumFlashPos = Game.CursorPos;
            if (ObjectManager.Player.Position.Distance(maximumFlashPos) > flashRange)
            {
                maximumFlashPos = ObjectManager.Player.Position + Vector3.Normalize(maximumFlashPos - ObjectManager.Player.Position) * flashRange;
            }
            expectedFlashPos = closestNonWall(maximumFlashPos);
            Drawing.DrawLine(Drawing.WorldToScreen(maximumFlashPos), Drawing.WorldToScreen(ObjectManager.Player.Position), 5, System.Drawing.Color.Red);
            var boja = System.Drawing.Color.Yellow;
            if (NavMesh.IsWallOfGrass(expectedFlashPos, 1)) { boja = System.Drawing.Color.Green; }
            Drawing.DrawLine(Drawing.WorldToScreen(expectedFlashPos), Drawing.WorldToScreen(ObjectManager.Player.Position), 5, boja);
            */
            for (int i = 0; i < Spots.Count; i++)
            {
                if (Spots[i].start.IsOnScreen())
                {
                    if (i == closestFlashSpot)
                    {
                        Render.Circle.DrawCircle(Spots[i].start, 50, System.Drawing.Color.LightGreen, thick);
                        if (someSpellReady(Spots[i].start))
                        {
                            Drawing.DrawLine(Drawing.WorldToScreen(Spots[i].start), Drawing.WorldToScreen(Spots[i].end), 2, System.Drawing.Color.LightGreen);
                        }
                    }
                    else
                    {
                        Render.Circle.DrawCircle(Spots[i].start, 50, System.Drawing.Color.Red, thick);
                        if (someSpellReady(Spots[i].start))
                        {
                            Drawing.DrawLine(Drawing.WorldToScreen(Spots[i].start), Drawing.WorldToScreen(Spots[i].end), 2, System.Drawing.Color.Red);
                        }
                    }
                }
            }
        }
        private static bool someSpellReady(Vector3 pos)
        {
            return ObjectManager.Player.Spellbook.CanUseSpell(flash) == SpellState.Ready || (ObjectManager.Player.ChampionName == "Shaco" && willBeAbleToCastOnArrival(SpellSlot.Q, pos));
        }
        private static void findClosest()
        {
            double dist = double.PositiveInfinity;
            int index = -1;
            for (int i = 0; i < Spots.Count; i++)
            {
                if (Game.CursorPos.Distance(Spots[i].start, true) < 2500 && Game.CursorPos.Distance(Spots[i].start, true) < dist)
                {
                    dist = Game.CursorPos.Distance(Spots[i].start, true);
                    index = i;
                }
            }
            closestFlashSpot = index;
        }
        static bool positionIsReachable(Vector3 pos)
        {
            return (Math.Abs(ObjectManager.Player.GetPath(pos).Last().X - pos.X) < 2 & Math.Abs(ObjectManager.Player.GetPath(pos).Last().Y - pos.Y) < 2);
        }
        static Vector3 closestNonWall(Vector3 pos)
        {
            if (positionIsReachable(pos))
            {
                return pos;
            }
            else
            {
                return ObjectManager.Player.GetPath(pos).Last();
            }
        }
        private static void fillSpots()
        {
            Spots = new List<FlashSpot> {
                new FlashSpot(new Vector3(956.6833f, 2646.205f, 95.74805f), new Vector3(1322.899f, 2485.314f, 95.74795f), new Vector3(1322.899f, 2485.314f, 95.74795f)),
                new FlashSpot(new Vector3(2420f, 6132f, 57.02493f), new Vector3(2020.505f, 6151.897f, 54.1672f), new Vector3(1724f, 6158f, 52.94329f)),
                new FlashSpot(new Vector3(2424f, 6508f, 57.00919f), new Vector3(2053.894f, 6659.709f, 54.59755f), new Vector3(1774f, 6808f, 52.8381f)),
                new FlashSpot(new Vector3(2474f, 6908f, 53.3024f), new Vector3(2075.389f, 6874.696f, 53.04325f), new Vector3(1774f, 6908f, 52.8381f)),
                new FlashSpot(new Vector3(1774f, 6840f, 52.8381f), new Vector3(2147.165f, 6984.034f, 51.38979f), new Vector3(2324f, 7258f, 50.04041f)),
                new FlashSpot(new Vector3(1724f, 6508f, 52.83856f), new Vector3(2111.575f, 6409.104f, 55.07844f), new Vector3(2424f, 6408f, 57.01263f)),
                new FlashSpot(new Vector3(1736f, 6050f, 53.60318f), new Vector3(2135.232f, 6074.711f, 55.44485f), new Vector3(2424f, 6058f, 57.02872f)),
                new FlashSpot(new Vector3(4224f, 5808f, 52.50096f), new Vector3(4213.235f, 5408.148f, 50.86628f), new Vector3(4374f, 5258f, 50.23714f)),
                new FlashSpot(new Vector3(3574f, 5908f, 52.48913f), new Vector3(3365.84f, 5566.432f, 53.22365f), new Vector3(3274f, 5358f, 53.73761f)),
                new FlashSpot(new Vector3(3924f, 5808f, 52.504f), new Vector3(3844.622f, 5415.955f, 52.30323f), new Vector3(3724f, 5208f, 52.41418f)),
                new FlashSpot(new Vector3(4372f, 5248f, 50.23569f), new Vector3(4268.507f, 5634.377f, 51.69048f), new Vector3(4224f, 5808f, 52.50095f)),
                new FlashSpot(new Vector3(3268f, 5356f, 53.72001f), new Vector3(3480.606f, 5694.818f, 52.75827f), new Vector3(3574f, 5908f, 52.48915f)),
                new FlashSpot(new Vector3(3704f, 5196f, 52.574f), new Vector3(3931.44f, 5525.045f, 52.53111f), new Vector3(3924f, 5808f, 52.50471f)),
                new FlashSpot(new Vector3(4910f, 6924f, 50.63771f), new Vector3(5253.552f, 6719.131f, 51.26581f), new Vector3(5524f, 6408f, 51.59957f)),
                new FlashSpot(new Vector3(6340f, 5230f, 48.52725f), new Vector3(6600.306f, 4926.288f, 48.52702f), new Vector3(6624f, 4808f, 48.527f)),
                new FlashSpot(new Vector3(7472f, 3366f, 52.58096f), new Vector3(7860.603f, 3460.804f, 51.89844f), new Vector3(7860.603f, 3460.804f, 51.89844f)),
                new FlashSpot(new Vector3(7506f, 3270f, 52.58354f), new Vector3(7128.158f, 3138.717f, 52.57823f), new Vector3(7128.158f, 3138.717f, 52.57823f)),
                new FlashSpot(new Vector3(7422f, 2308f, 51.75258f), new Vector3(7228.897f, 1957.705f, 49.62641f), new Vector3(7224f, 1708f, 49.44692f)),
                new FlashSpot(new Vector3(8272f, 2908f, 51.13f), new Vector3(7895.015f, 2774.28f, 52.13895f), new Vector3(7622f, 2858f, 52.53639f)),
                new FlashSpot(new Vector3(8572f, 2908f, 51.07707f), new Vector3(8959.891f, 3005.656f, 53.16409f), new Vector3(9222f, 2758f, 49.22295f)),
                new FlashSpot(new Vector3(9508f, 2712f, 49.22297f), new Vector3(9459.178f, 2315.042f, 55.64545f), new Vector3(9422f, 2258f, 54.32547f)),
                new FlashSpot(new Vector3(10972f, 2508f, 49.2229f), new Vector3(11313.07f, 2712.094f, 4.298306f), new Vector3(11572f, 2958f, -60.02427f)),
                new FlashSpot(new Vector3(11040f, 2296f, 49.2229f), new Vector3(11354.91f, 2538.93f, 6.603291f), new Vector3(11672f, 2308f, 50.41902f)),
                new FlashSpot(new Vector3(11472f, 3058f, -68.70793f), new Vector3(11238.95f, 2740.554f, 1.38604f), new Vector3(10972f, 2508f, 49.2229f)),
                new FlashSpot(new Vector3(11672f, 2358f, 50.53391f), new Vector3(11275.71f, 2412.378f, 49.72529f), new Vector3(11022f, 2408f, 49.2229f)),
                new FlashSpot(new Vector3(11972f, 3908f, -66.28026f), new Vector3(12254.91f, 4183.016f, -0.4985962f), new Vector3(12372f, 4508f, 51.7294f)),
                new FlashSpot(new Vector3(12222f, 4558f, 51.7294f), new Vector3(12212.1f, 4166.981f, -31.97156f), new Vector3(11922f, 4158f, -71.2406f)),
                new FlashSpot(new Vector3(12422f, 4508f, 51.7294f), new Vector3(12749.31f, 4278.073f, 51.51523f), new Vector3(13072f, 4258f, 51.43146f)),
                new FlashSpot(new Vector3(11930f, 4838f, 51.7294f), new Vector3(12199.78f, 5133.326f, 51.72938f), new Vector3(12272f, 5158f, 51.7294f)),
                new FlashSpot(new Vector3(11022f, 6358f, 51.27539f), new Vector3(10712.71f, 6118.737f, -32.93628f), new Vector3(10472f, 5858f, -71.2406f)),
                new FlashSpot(new Vector3(10370f, 6724f, 51.98075f), new Vector3(9995.37f, 6584.541f, 37.72188f), new Vector3(9995.37f, 6584.541f, 37.72188f)),
                new FlashSpot(new Vector3(10336f, 7432f, 51.83269f), new Vector3(10080.67f, 7739.909f, 51.75459f), new Vector3(10080.67f, 7739.909f, 51.75459f)),
                new FlashSpot(new Vector3(9858f, 8090f, 52.35648f), new Vector3(9585.739f, 8383.042f, 51.83698f), new Vector3(9372f, 8606f, 51.899f)),
                new FlashSpot(new Vector3(8516f, 9690f, 50.38408f), new Vector3(8245.71f, 9984.86f, 49.66603f), new Vector3(8322f, 10106f, 50.3338f)),
                new FlashSpot(new Vector3(7444f, 11520f, 53.6413f), new Vector3(7069.679f, 11378.99f, 54.1552f), new Vector3(7069.679f, 11378.99f, 54.1552f)),
                new FlashSpot(new Vector3(7340f, 11610f, 49.9489f), new Vector3(7719.715f, 11735.68f, 54.48843f), new Vector3(7719.715f, 11735.68f, 54.48843f)),
                new FlashSpot(new Vector3(6574f, 12056f, 56.4768f), new Vector3(6959.226f, 12163.71f, 56.4768f), new Vector3(7174f, 12306f, 54.76827f)),
                new FlashSpot(new Vector3(6324f, 12006f, 56.4768f), new Vector3(5925.074f, 11976.76f, 58.1337f), new Vector3(5774f, 12206f, 56.37742f)),
                new FlashSpot(new Vector3(5244f, 12202f, 56.4768f), new Vector3(5358.162f, 12585.36f, 54.25264f), new Vector3(5424f, 12606f, 52.8381f)),
                new FlashSpot(new Vector3(4024f, 12206f, 56.4768f), new Vector3(3693.211f, 11990.73f, -8.615967f), new Vector3(3474f, 11756f, -62.06449f)),
                new FlashSpot(new Vector3(3498f, 11766f, -62.12f), new Vector3(3750.298f, 12061.42f, 33.14037f), new Vector3(3974f, 12256f, 56.4768f)),
                new FlashSpot(new Vector3(3124f, 12056f, -3.842518f), new Vector3(3449.949f, 12286.07f, 24.87287f), new Vector3(3774f, 12556f, 56.4768f)),
                new FlashSpot(new Vector3(3806f, 12472f, 56.4768f), new Vector3(3441.063f, 12309.82f, 33.69077f), new Vector3(3174f, 12006f, -23.74425f)),
                new FlashSpot(new Vector3(2402f, 10412f, 54.3255f), new Vector3(2085.936f, 10657.16f, 53.42793f), new Vector3(1774f, 10656f, 52.8381f)),
                new FlashSpot(new Vector3(2774f, 10406f, 54.3255f), new Vector3(2840.656f, 10793.31f, -20.13541f), new Vector3(2974f, 10906f, -70.75439f)),
                new FlashSpot(new Vector3(2970f, 9970f, 53.77024f), new Vector3(2648.805f, 9731.602f, 54.25334f), new Vector3(2574f, 9756f, 54.3255f)),
                new FlashSpot(new Vector3(3796f, 8584f, 50.61792f), new Vector3(4105.992f, 8825.705f, -23.4319f), new Vector3(4374f, 9056f, -66.04797f)),
                new FlashSpot(new Vector3(4374f, 7456f, 50.21755f), new Vector3(4699.406f, 7223.383f, 50.64851f), new Vector3(4699.406f, 7223.383f, 50.64851f)),
                new FlashSpot(new Vector3(3128f, 8224f, 51.79534f), new Vector3(3257.462f, 7845.53f, 51.69088f), new Vector3(3257.462f, 7845.53f, 51.69088f)),
                new FlashSpot(new Vector3(3942f, 7738f, 51.87905f), new Vector3(3542f, 7738.129f, 52.37252f), new Vector3(3542f, 7738.129f, 52.37252f)),
                new FlashSpot(new Vector3(2970f, 10946f, -71.2379f), new Vector3(2760.656f, 10620.3f, 29.24263f), new Vector3(2774f, 10406f, 54.3255f)),
                new FlashSpot(new Vector3(6224f, 8106f, -67.3774f), new Vector3(6031.075f, 7770.117f, 32.43635f), new Vector3(5924f, 7656f, 51.65455f)),
                new FlashSpot(new Vector3(5506f, 8490f, -71.2406f), new Vector3(5484.033f, 8100.012f, 14.93813f), new Vector3(5474f, 7906f, 51.67511f)),
                new FlashSpot(new Vector3(5626f, 9482f, -71.2406f), new Vector3(5354.457f, 9188.292f, -71.24049f), new Vector3(5354.457f, 9188.292f, -71.24049f)),
                new FlashSpot(new Vector3(5928f, 7650f, 51.65454f), new Vector3(6160.292f, 7968.275f, -17.2006f), new Vector3(6274f, 8056f, -67.03541f)),
                new FlashSpot(new Vector3(5462f, 7898f, 51.67579f), new Vector3(5396.459f, 8287.721f, -10.14526f), new Vector3(5524f, 8506f, -71.2406f)),
                new FlashSpot(new Vector3(9028f, 5438f, -71.2406f), new Vector3(9371.965f, 5642.177f, -71.2406f), new Vector3(9371.965f, 5642.177f, -71.2406f)),
                new FlashSpot(new Vector3(9272f, 6408f, -71.2406f), new Vector3(9433.435f, 6756.245f, 41.29436f), new Vector3(9522f, 6958f, 52.29671f)),
                new FlashSpot(new Vector3(8772f, 6708f, -71.2406f), new Vector3(9008.457f, 7014.54f, 29.36414f), new Vector3(9122f, 7108f, 53.03516f)),
                new FlashSpot(new Vector3(9122f, 7108f, 53.03612f), new Vector3(8863.602f, 6821.46f, -52.43877f), new Vector3(8772f, 6708f, -71.2406f)),
                new FlashSpot(new Vector3(9522f, 6956f, 52.31181f), new Vector3(9361.282f, 6599.546f, -32.0097f), new Vector3(9272f, 6408f, -71.2406f)),
                new FlashSpot(new Vector3(10936f, 7180f, 51.72334f), new Vector3(11335.86f, 7169.456f, 51.72509f), new Vector3(11335.86f, 7169.456f, 51.72509f)),
                new FlashSpot(new Vector3(8922f, 4958f, 51.59026f), new Vector3(8669.179f, 4648.03f, 51.95475f), new Vector3(8669.179f, 4648.03f, 51.95475f)),
                new FlashSpot(new Vector3(9022f, 4358f, 52.85026f), new Vector3(8660.763f, 4529.772f, 51.52179f), new Vector3(8660.763f, 4529.772f, 51.52179f)),
                new FlashSpot(new Vector3(5954f, 9868f, 52.91689f), new Vector3(6284.438f, 10093.41f, 53.34819f), new Vector3(6284.438f, 10093.41f, 53.34819f)),
                new FlashSpot(new Vector3(5824f, 10306f, 54.51609f), new Vector3(6223.998f, 10305.73f, 53.37901f), new Vector3(6223.998f, 10305.73f, 53.37901f)),
                new FlashSpot(new Vector3(6606f, 11744f, 53.83185f), new Vector3(6719.207f, 11360.35f, 53.78794f), new Vector3(6724f, 11406f, 53.82968f)),
                new FlashSpot(new Vector3(6292f, 10224f, 53.74763f), new Vector3(6610.332f, 10466.2f, 55.51226f), new Vector3(6824f, 10656f, 55.9997f)),
                new FlashSpot(new Vector3(8628f, 4596f, 51.8604f), new Vector3(8274.423f, 4408.967f, 53.14166f), new Vector3(8022f, 4258f, 53.7207f)),
                new FlashSpot(new Vector3(8472f, 3258f, 53.41605f), new Vector3(8188.322f, 3540.002f, 51.98015f), new Vector3(8172f, 3508f, 51.74901f)),
                new FlashSpot(new Vector3(6040f, 4548f, 48.53369f), new Vector3(6439.99f, 4550.846f, 48.52854f), new Vector3(6439.99f, 4550.846f, 48.52854f)),
                new FlashSpot(new Vector3(6240f, 3332f, 50.24102f), new Vector3(6592.858f, 3143.609f, 50.18488f), new Vector3(6592.858f, 3143.609f, 50.18488f)),
                new FlashSpot(new Vector3(6180f, 3382f, 50.39332f), new Vector3(5814.911f, 3545.429f, 51.15898f), new Vector3(5814.911f, 3545.429f, 51.15898f)),
                new FlashSpot(new Vector3(11018.34f, 6895.186f, 51.72306f), new Vector3(11366.39f, 7092.312f, 51.72422f), new Vector3(11366.39f, 7092.312f, 51.72422f)),
                new FlashSpot(new Vector3(12422f, 8706f, 52.1927f), new Vector3(12817.9f, 8763.115f, 52.24541f), new Vector3(13122f, 8706f, 52.3063f)),
                new FlashSpot(new Vector3(12396f, 8094f, 52.1471f), new Vector3(12795.44f, 8115.19f, 52.24578f), new Vector3(13072f, 7956f, 52.3063f)),
                new FlashSpot(new Vector3(13056f, 7938f, 52.3063f), new Vector3(12685.63f, 8089.073f, 52.31953f), new Vector3(12372f, 8106f, 52.18473f)),
                new FlashSpot(new Vector3(13104f, 8700f, 51.98204f), new Vector3(12704.94f, 8672.57f, 52.01126f), new Vector3(12422f, 8706f, 51.6209f)),
                new FlashSpot(new Vector3(11472f, 9606f, 52.3063f), new Vector3(11432.66f, 9208.081f, 62.92871f), new Vector3(11272f, 9006f, 67.01875f)),
                new FlashSpot(new Vector3(11022f, 9756f, 52.3063f), new Vector3(10922.55f, 9368.732f, 63.89262f), new Vector3(10922f, 9156f, 66.42325f)),
                new FlashSpot(new Vector3(10572f, 9756f, 52.3063f), new Vector3(10608.86f, 9357.775f, 59.93228f), new Vector3(10622f, 9206f, 65.76476f)),
                new FlashSpot(new Vector3(10628f, 9186f, 64.91545f), new Vector3(10607.78f, 9585.422f, 57.58028f), new Vector3(10572f, 9756f, 52.3063f)),
                new FlashSpot(new Vector3(10934f, 9118f, 66.11456f), new Vector3(10964.9f, 9516.711f, 57.4443f), new Vector3(11072f, 9706f, 52.3063f)),
                new FlashSpot(new Vector3(11290f, 9008f, 67.02673f), new Vector3(11404.87f, 9391.033f, 57.49783f), new Vector3(11522f, 9556f, 52.3063f)),
                new FlashSpot(new Vector3(8772f, 10324f, 50.48529f), new Vector3(8376.394f, 10383.13f, 50.37312f), new Vector3(8376.394f, 10383.13f, 50.37312f)),
                new FlashSpot(new Vector3(8622f, 11236f, 51.36238f), new Vector3(8993.561f, 11384.12f, 53.36196f), new Vector3(8993.561f, 11384.12f, 53.36196f)),
                new FlashSpot(new Vector3(7496f, 12572f, 56.4768f), new Vector3(7709.668f, 12910.14f, 54.34048f), new Vector3(7722f, 13206f, 52.8381f)),
                new FlashSpot(new Vector3(10482f, 3628f, 47.55863f), new Vector3(10272f, 4108f, -71.2406f), new Vector3(10396.63f, 4009.266f, -38.15991f)),
                new FlashSpot(new Vector3(3846f, 10828f, -71.22473f), new Vector3(4474f, 10606f, -71.2406f), new Vector3(4239.508f, 10756.22f, -71.2343f)),
                new FlashSpot(new Vector3(4424f, 11306f, 49.04849f), new Vector3(4624f, 10756f, -71.2406f), new Vector3(4490.276f, 10922.25f, -42.27382f)),
                new FlashSpot(new Vector3(5524f, 9506f, -71.2406f), new Vector3(5274f, 10106f, -71.2406f), new Vector3(5481.263f, 9903.711f, -71.2406f)),
                new FlashSpot(new Vector3(4492f, 8122f, 48.91035f), new Vector3(4835.491f, 8324.963f, 20.27289f), new Vector3(4835.491f, 8324.963f, 20.27289f)),
                new FlashSpot(new Vector3(3846.777f, 8089.252f, 51.37996f), new Vector3(3537.911f, 7835.093f, 53.59471f), new Vector3(3537.911f, 7835.093f, 53.59471f)),
                new FlashSpot(new Vector3(11704f, 6654f, 51.72552f), new Vector3(11633.5f, 7047.739f, 51.72623f), new Vector3(11633.5f, 7047.739f, 51.72623f)),
                new FlashSpot(new Vector3(6836f, 5574f, 57.20641f), new Vector3(6424f, 5308f, 48.5273f), new Vector3(6516.246f, 5333.793f, 49.61449f)),
                new FlashSpot(new Vector3(7972f, 9306f, 52.44665f), new Vector3(8372f, 9606f, 50.3841f), new Vector3(8325.443f, 9439.265f, 50.3844f)),
                new FlashSpot(new Vector3(6874f, 10656f, 55.99911f), new Vector3(6274f, 10306f, 53.67197f), new Vector3(6531.542f, 10449.32f, 53.72581f)),
                new FlashSpot(new Vector3(8022f, 4258f, 53.72062f), new Vector3(8572f, 4558f, 51.36862f), new Vector3(8363.293f, 4466.604f, 51.87788f)),
                new FlashSpot(new Vector3(9178f, 5392f, -71.24659f), new Vector3(9572f, 4908f, -71.2406f), new Vector3(9388.395f, 5051.803f, -71.24259f)),
                new FlashSpot(new Vector3(10962f, 4060f, -71.2406f), new Vector3(10422f, 4258f, -71.2406f), new Vector3(10565.31f, 4111.331f, -71.2406f)),
                new FlashSpot(new Vector3(10472f, 5858f, -71.2406f), new Vector3(10727.26f, 6151.174f, 23.06097f), new Vector3(11022f, 6358f, 51.32826f)),
                new FlashSpot(new Vector3(6194f, 3594f, 49.99485f), new Vector3(5799.531f, 3527.718f, 51.11725f), new Vector3(5799.531f, 3527.718f, 51.11725f)),
                new FlashSpot(new Vector3(8678f, 11496f, 53.61436f), new Vector3(9064.474f, 11392.86f, 54.01519f), new Vector3(9064.474f, 11392.86f, 54.01519f)),
                new FlashSpot(new Vector3(8608f, 11528f, 53.03674f), new Vector3(8279.201f, 11755.78f, 55.6813f), new Vector3(8279.201f, 11755.78f, 55.6813f))};
        }
    }
}