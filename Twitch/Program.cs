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

        private static float GetDamage(Obj_AI_Hero target)
        {
            return GetEDamage(target)+getPassiveDamage(target);
        }
        private static float GetEDamage(Obj_AI_Hero target)
        {
            return _e.GetDamage(target);
        }
        private static float getPassiveDamage(Obj_AI_Hero target)
        {
            BuffInstance buff = target.GetBuff("twitchdeadlyvenom");
            float passiveDurationMax=_config.Item("PassDur").GetValue<Slider>().Value;
            int passiveDurationSeconds = (int)Math.Floor(Math.Min((buff.EndTime - Game.Time), passiveDurationMax));
            float totalPassiveDamage = buff.Count * (12 + (6 * ((Player.Level - 1) / 4)));
            float passiveDamagePerTick = totalPassiveDamage / 6;
            float passiveDamage = passiveDamagePerTick * passiveDurationSeconds;
            return passiveDamage+getIgniteDamage(target)-getMaximumRegen(target,passiveDurationSeconds);
        }
        private static float getIgniteDamage(Obj_AI_Hero target)
        {
            if (!target.HasBuff("SummonerDot")) { return 0; }
            BuffInstance buff = target.GetBuff("SummonerDot");
            float igniteDurationMax = _config.Item("PassDur").GetValue<Slider>().Value;
            int igniteDurationSeconds = (int)Math.Floor(Math.Min((buff.EndTime - Game.Time), igniteDurationMax));
            float totalPassiveDamage = 50 + 20 * Player.Level;
            float igniteDamagePerTick = totalPassiveDamage / 5;
            float igniteDamage = igniteDamagePerTick * igniteDurationSeconds;
            return igniteDamage;
        }
        private static float getMaximumRegen(Obj_AI_Hero target, int time)
        {
            return target.HPRegenRate* time * 2;;
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

            _config.SubMenu("Secure Kill").AddItem(new MenuItem("EDamage", "Health gone after X seconds").SetValue(new Circle(true, Color.White)));
            _config.SubMenu("Secure Kill").AddItem(new MenuItem("PassDur", "X (0 - dont wait for passive)").SetValue(new Slider(6,0,6)));

            _config.SubMenu("Drawings").AddItem(new MenuItem("drawStealth", "Draw stealth indicator").SetValue(true));
            _config.SubMenu("Drawings").AddItem(new MenuItem("stealthColor", "Stealth indicator color").SetValue(new Circle(true, Color.Purple)));

            _config.AddToMainMenu();

            CustomDamageIndicator.Initialize(GetDamage);
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
            if (_config.Item("drawStealth").GetValue<Boolean>())
            {
                if (Player.HasBuff("TwitchHideInShadows"))
                {
                    float rad = ((Game.Time-Player.GetBuff("TwitchHideInShadows").StartTime)/getStealthDuration())*700;
                    Drawing.DrawCircle(Player.Position, rad, _config.Item("stealthColor").GetValue<Circle>().Color);
                    lastQStarted = 0;
                }
                if (lastQStarted!= 0 && (lastQStarted+4.5>Game.Time || lastTimeAttacked+1.5>Game.Time))
                {
                    float timeNeeded = (float)Math.Min(lastQStarted + 4.5 - Game.Time, lastTimeAttacked + 1.5 - Game.Time);
                    float rad = ((1.5f-timeNeeded)/1.5f) * 700;
                    Drawing.DrawCircle(Player.Position, rad, _config.Item("stealthColor").GetValue<Circle>().Color);
                }
            }
        } 
        private static float getStealthDuration()
        {
            return Player.Spellbook.GetSpell(SpellSlot.Q).Level + 3;
        }
        private static bool ePassiveComboKills(Obj_AI_Hero target)
        {
            float damage = GetDamage(target);
            if (damage > target.Health + target.PhysicalShield)
            {
                return true;
            }
            return false;
        }
        private static void Game_OnUpdate(EventArgs args)
        {
            if (_e.IsReady())
            {
                foreach (var enemy in ObjectManager.Get<Obj_AI_Hero>().Where(enemy => enemy.IsValidTarget(_e.Range) && enemy.HasBuff("twitchdeadlyvenom") && ePassiveComboKills(enemy)))
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
                if (target != null && target.Type == Player.Type &&
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
                if (target != null && target.Type == Player.Type && Orbwalking.InAutoAttackRange(target))
                {
                    Items.UseItem(3142);
                }
            }
        }
    }
}
