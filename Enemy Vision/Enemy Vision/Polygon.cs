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
    class Polygon
    {
        public List<IntPoint> polygon;
        public Polygon(Vector3 pos, float range, PolygonConstants pc)
        {
            polygon = new List<IntPoint>();
            float d = range / pc.lineDetail;
            for (int i = 0; i < pc.circleDetail; i++)
            {
                innerLoop(i, pos, pc, d);
            }
        }
        private void innerLoop(int i, Vector3 pos, PolygonConstants pc, float d)
        {
            for (int j = 0; j < pc.lineDetail; j++)
            {
                pos.X += pc.cosTable[i] * d;
                pos.Y += pc.sinTable[i] * d;
                if (blocksSight(pos))
                {
                    polygon.Add(new IntPoint(pos.X,pos.Y));
                    return;
                }
            }
            polygon.Add(new IntPoint(pos.X, pos.Y));
        }
        private bool blocksSight(Vector3 pos)
        {
            return (NavMesh.GetCollisionFlags(pos) == CollisionFlags.Wall || NavMesh.IsWallOfGrass(pos,100));
        }
    }
}
