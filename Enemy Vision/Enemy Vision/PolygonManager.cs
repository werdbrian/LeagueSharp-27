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
    using Path = List<IntPoint>;
    using Paths = List<List<IntPoint>>;
    class PolygonManager
    {
        Polygon[] polygonsArray;
        Clipper clipper;
        Paths solution;
        public PolygonConstants pc;
        private float championSightRange = 1200;
        private float towerSightRange = 1095;
        private float minionSightRange = 1100;
        float maximumDistanceFromCenter;
        public List<Polygon> polygons;
        public PolygonManager()
        {
            solution = new Paths();
            pc = new PolygonConstants();
            polygons = new List<Polygon>();
        }
        public void update()
        {
            Vector3 screenMiddle = Drawing.ScreenToWorld((float)Drawing.Width / 2f, (float)Drawing.Height / 2f); //works
            maximumDistanceFromCenter = 3000;
            polygons = new List<Polygon>();
            //MINIONS
            var minions = MinionManager.GetMinions(screenMiddle, minionSightRange + maximumDistanceFromCenter, MinionTypes.All, MinionTeam.Enemy);
            foreach (Obj_AI_Minion obj in minions)
            {
                polygons.Add(new Polygon(obj.Position, minionSightRange,pc));
            }

            // TOWERS
            foreach (var obj in ObjectManager.Get<Obj_AI_Turret>())
            {
                if ((obj.Position.Distance(screenMiddle) < maximumDistanceFromCenter + towerSightRange) && obj.Team != ObjectManager.Player.Team)
                {
                    polygons.Add(new Polygon(obj.Position, towerSightRange, pc));
                }
            }

            // CHAMPIONS
            foreach (var obj in ObjectManager.Get<Obj_AI_Hero>())
            {
                if ((obj.Position.Distance(screenMiddle) < maximumDistanceFromCenter + championSightRange) && obj.Team != ObjectManager.Player.Team)
                {
                    polygons.Add(new Polygon(obj.Position, championSightRange, pc));
                }
            }
            getUnion();
        }
        private List<List<IntPoint>> getPolygons()
        {
            List<List<IntPoint>> polygonsForExport = new List<List<IntPoint>>();
            foreach (Polygon p in polygons)
            {
                polygonsForExport.Add(p.polygon);
            }
            return polygonsForExport;
        }
        private void getUnion()
        {
            List<List<IntPoint>> defaultPolygon = new List<List<IntPoint>>() { new List<IntPoint>()
                                                                             { new IntPoint(0,0),
                                                                               new IntPoint(16000,0),
                                                                               new IntPoint(16000,16000),
                                                                               new IntPoint(0,16000)}};
            List<Polygon> solution2 = new List<Polygon>();
            Clipper clipper = new Clipper();
            clipper.AddPaths(getPolygons(), PolyType.ptClip, true);
            clipper.AddPaths(defaultPolygon, PolyType.ptSubject, true);
            solution.Clear();
            bool succeeded = clipper.Execute(ClipType.ctIntersection, solution, PolyFillType.pftPositive, PolyFillType.pftPositive);
        }
        public void drawAll()
        {
            foreach (Path p in solution)
            {
                drawPath(p);
            }
        }
        private void drawPath(Path path)
        {
            for (int i = 0; i < path.Count; i++)
            {
                DrawLine(path[i], path[(i + 1) % path.Count],1);
            }
        }
        private void DrawLine(IntPoint start, IntPoint end, int width)
        {
            var from = Drawing.WorldToScreen(new Vector3(start.X,start.Y,NavMesh.GetHeightForPosition(start.X,start.Y)));
            var to = Drawing.WorldToScreen(new Vector3(end.X, end.Y, NavMesh.GetHeightForPosition(end.X, end.Y)));
            Drawing.DrawLine(from[0], from[1], to[0], to[1], width, pc.color);

        }
    }
}
