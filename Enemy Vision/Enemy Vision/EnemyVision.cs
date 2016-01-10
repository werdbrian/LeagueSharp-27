using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using ClipperLib;

namespace Enemy_Vision
{
    class EnemyVision
    {
        private PolygonManager pm;
        private Menu _config;
        private Obj_AI_Hero Player = ObjectManager.Player;

        public EnemyVision()
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        private void Game_OnGameLoad(EventArgs args)
        {
            _config = new Menu("EnemyVision", "Enemy Vision", true);
            _config.AddItem(new MenuItem("enabled", "Enabled")).SetValue(new KeyBind(32, KeyBindType.Press));
            _config.AddItem(new MenuItem("color", "Color").SetValue(new Circle(true, System.Drawing.Color.Red)));
            _config.AddItem(new MenuItem("lineSegments", "Line Segments").SetValue(new Slider(50, 20, 100)));
            _config.AddItem(new MenuItem("circleSegments", "Circle Segments").SetValue(new Slider(90, 20, 180)));
            _config.AddToMainMenu();

            pm = new PolygonManager();
            pm.pc.color = _config.Item("color").GetValue<Circle>().Color;

            _config.Item("color").ValueChanged += configChanged;
            _config.Item("lineSegments").ValueChanged += configChanged;
            _config.Item("circleSegments").ValueChanged += configChanged;

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
        }
        private void configChanged(object sender, OnValueChangeEventArgs args)
        {
            pm.pc.color = _config.Item("color").GetValue<Circle>().Color;
            pm.pc.circleDetail = _config.Item("circleSegments").GetValue<Slider>().Value;
            pm.pc.lineDetail = _config.Item("lineSegments").GetValue<Slider>().Value;
            pm.pc.update();

        }
        private void Game_OnUpdate(EventArgs args)
        {
            if (_config.Item("enabled").GetValue<KeyBind>().Active)
            {
                pm.update();
            }
        }
        private void Drawing_OnDraw(EventArgs args)
        {
            if (_config.Item("enabled").GetValue<KeyBind>().Active)
            {
                pm.drawAll();
            }
        }
    }
}
