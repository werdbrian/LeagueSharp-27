using System;
using System.Drawing;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Twitch
{
    public class Program
    {
        private static float lastQStarted = 0;
        private static float lastTimeAttacked = 0;
        private const int eRange = 1200;
        private const int wRange = 950;
        private const int rRange = 850;
        private static Menu _config;
        private static Orbwalking.Orbwalker _orbwalker;
        private static Spell _w;
        private static Spell _e;
        private static Spell _passive;

        private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        private static float GetEDamage(Obj_AI_Hero target)
        {
            return _e.GetDamage(target);
        }
        private static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Twitch")
                return;

            _w = new Spell(SpellSlot.W, wRange);
            _w.SetSkillshot(0.25f, 120f, 1400f, false, SkillshotType.SkillshotCircle);
            _e = new Spell(SpellSlot.E, eRange);

            _config = new Menu("Twitch", "Twitch", true);

            _orbwalker = new Orbwalking.Orbwalker(_config.SubMenu("Orbwalking"));

            var targetSelectorMenu = new Menu("Target Selector", "Target Selector");
            TargetSelector.AddToMenu(targetSelectorMenu);
            _config.AddSubMenu(targetSelectorMenu);

            _config.SubMenu("Combo").AddItem(new MenuItem("UseWCombo", "Use W").SetValue(true));
            _config.SubMenu("Combo").AddItem(new MenuItem("ghost", "Use Ghostblade").SetValue(true));
            _config.SubMenu("Combo").AddItem(new MenuItem("botrk", "Use Botrk").SetValue(true));

            _config.SubMenu("Drawings").AddItem(new MenuItem("ultDraw", "Draw ult range").SetValue(true));
            _config.SubMenu("Drawings").AddItem(new MenuItem("EDamage", "E Damage").SetValue(new Circle(true, Color.White)));
            _config.SubMenu("Drawings").AddItem(new MenuItem("stealthColor", "Stealth indicator").SetValue(new Circle(true, Color.Purple)));

            _config.AddToMainMenu();

            CustomDamageIndicator.Initialize(GetEDamage);
            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Obj_AI_Base.OnProcessSpellCast += OnSpellProcess;
            Obj_AI_Base.OnDamage += OnDamage;
        }
        private static void OnSpellProcess(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (sender.IsMe && args.Slot == SpellSlot.Q)
            {
                lastQStarted = Game.Time + (2*Game.Ping/1000f);
                lastTimeAttacked = Game.Time + (2*Game.Ping / 1000f);
            }
        }
        private static void OnDamage(AttackableUnit sender, AttackableUnitDamageEventArgs args)
        {
            if (args.TargetNetworkId == Player.NetworkId)
            {
                lastTimeAttacked = Game.Time + (2*Game.Ping / 1000f);
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            CustomDamageIndicator.DrawingColor = _config.Item("EDamage").GetValue<Circle>().Color;
            CustomDamageIndicator.Enabled = _config.Item("EDamage").GetValue<Circle>().Active;
            if (_config.Item("ultDraw").GetValue<Boolean>() && !Player.HasBuff("TwitchFullAutomatic"))
            {
                Render.Circle.DrawCircle(Player.Position, 1000, Color.Yellow,1);
            }
            if (_config.Item("stealthColor").GetValue<Circle>().Active)
            {
                if (Player.HasBuff("TwitchHideInShadows"))
                {
                    float rad = ((Game.Time-Player.GetBuff("TwitchHideInShadows").StartTime)/getStealthDuration())*700;
                    Render.Circle.DrawCircle(Player.Position, rad, _config.Item("stealthColor").GetValue<Circle>().Color);
                    lastQStarted = 0;
                }
                if (lastQStarted!= 0 && (lastQStarted+4.5>Game.Time || lastTimeAttacked+1.5>Game.Time))
                {
                    float timeNeeded = (float)Math.Min(lastQStarted + 4.5 - Game.Time, lastTimeAttacked + 1.5 - Game.Time);
                    float rad = ((1.5f-timeNeeded)/1.5f) * 700;
                    Render.Circle.DrawCircle(Player.Position, rad, _config.Item("stealthColor").GetValue<Circle>().Color);
                }
            }
        } 
        private static float getStealthDuration()
        {
            return Player.Spellbook.GetSpell(SpellSlot.Q).Level + 3;
        }
        private static void Game_OnUpdate(EventArgs args)
        {
            if (_e.IsReady())
            {
                foreach (var enemy in ObjectManager.Get<Obj_AI_Hero>().Where(enemy => enemy.IsValidTarget(_e.Range) && enemy.Health<GetEDamage(enemy)))
                {
                    _e.Cast();
                }
                var minions = MinionManager.GetMinions(_e.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var m in minions)
                {
                    if ((m.BaseSkinName.Contains("Dragon") || m.BaseSkinName.Contains("Baron")) && _e.IsKillable(m))
                    {
                        _e.Cast();
                    }
                    break;
                }
            }   

            if (_orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
            {
                var target = TargetSelector.GetTarget(_w.Range, TargetSelector.DamageType.Physical);

                //Use W
                if (_config.Item("UseWCombo").GetValue<bool>())
                {
                    if (target.IsValidTarget(_w.Range) && _w.CanCast(target))
                    {
                        _w.Cast(target);
                    }
                }

                //Use Botrk
                if (target != null && _config.Item("botrk").GetValue<bool>() && target.Type == Player.Type &&
                    target.ServerPosition.Distance(Player.ServerPosition) < 450)
                {
                    var hasCutGlass = Items.HasItem(3144);
                    var hasBotrk = Items.HasItem(3153);

                    if (hasBotrk || hasCutGlass)
                    {
                        var itemId = hasCutGlass ? 3144 : 3153;
                        var damage = Player.GetItemDamage(target, Damage.DamageItems.Botrk);
                        if (hasCutGlass || Player.Health + damage < Player.MaxHealth)
                            Items.UseItem(itemId, target);
                    }
                }

                //Use Youmus
                if (target != null && _config.Item("ghost").GetValue<bool>() && target.Type == Player.Type && Orbwalking.InAutoAttackRange(target))
                {
                    Items.UseItem(3142);
                }
            }
        }
    }
}
