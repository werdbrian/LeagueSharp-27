using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClipperLib;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;


namespace NavMeshRemake
{
    using Polygon = System.Collections.Generic.List<ClipperLib.IntPoint>;
    using PolygonSet = System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>;
    using IntPoint = ClipperLib.IntPoint;
    public static class NavMeshRemake
    {
        private static PolygonSet getCollisionPolygonSet(PolygonSet p1, PolygonSet p2)
        {
            Clipper clipper = new Clipper();
            PolygonSet result = new PolygonSet();
            clipper.AddPaths(p1, PolyType.ptClip, true);
            clipper.AddPaths(p2, PolyType.ptSubject, true);
            bool succeeded = clipper.Execute(ClipType.ctIntersection, result, PolyFillType.pftPositive, PolyFillType.pftPositive);
            clipper.Clear();
            return result;
        }
        private static PolygonSet extrudePoint(Vector2 point, float offset, OffsetType offsetType)
        {
            PolygonSet p2 = new List<List<IntPoint>>() { new List<IntPoint>() { new IntPoint(point.X,point.Y),new IntPoint(point.X+1, point.Y) } };
            PolygonSet p1 = new PolygonSet();
            if (offsetType == OffsetType.round)
            {
                p1 = Generate.offsetLineRound(p2, offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p1 = Generate.offsetLineSquare(p2, offset);
            }
            return p1;
        }
        public static bool pointInPolygon(Vector2 point, CollisionType polyType, float offset = 1, OffsetType offsetType = OffsetType.round)
        {
            return getCollisionPolygons(point,polyType,offset,offsetType).Count > 0;    
        }
        public static bool pointInPolygon(Vector2 point, List<Vector2> v, float offset=1, OffsetType offsetType =OffsetType.round)
        {
            PolygonSet p1 = extrudePoint(point, offset, offsetType);
            return getCollisionPolygonSet(p1, new List<List<IntPoint>> { PolygonHelperClass.VectorToPoly(v) }).Count > 0;
        }
        public static bool pointInPolygon(Vector2 point, List<List<Vector2>> v, float offset = 1, OffsetType offsetType = OffsetType.round)
        {
            foreach (List<Vector2> vec in v)
            {
                if (pointInPolygon(point, vec,offset,offsetType)) { return true; }
            }
            return false;
        }
        public static float getHeightForPosition(float x, float y)
        {
            if (x < 0 || x > 15000 || y < 0 || y > 15000) { return 0; }
            x /= 100;
            y /= 100;
            float indexFloat = x + y * 150;
            return PremadePolygonSets.heightData[(int)Math.Round(indexFloat)];
        }
        public static void drawPolygon(List<List<Vector2>> vector, System.Drawing.Color color)
        {
            foreach (List<Vector2> poly in vector)
            {
                drawPolygon(poly, color);
            }
        }
        public static void drawPolygon(List<Vector2> vector, System.Drawing.Color color)
        {
            for (int i = 0; i < vector.Count; i++)
            {
                DrawLine(vector[i], vector[(i + 1) % vector.Count], 1, color);
            }
        }
        private static void DrawLine(Vector2 start, Vector2 end, int width, System.Drawing.Color color)
        {
            var from = LeagueSharp.Drawing.WorldToScreen(new Vector3(start.X, start.Y, getHeightForPosition(start.X, start.Y)));
            var to = LeagueSharp.Drawing.WorldToScreen(new Vector3(end.X, end.Y, getHeightForPosition(end.X, end.Y)));
            LeagueSharp.Drawing.DrawLine(from[0], from[1], to[0], to[1], width, color);
        }
        public static Vector2 getClosestPoint(List<List<Vector2>> vector, Vector2 point)
        {
            Vector2 currentClosest = new Vector2(float.MinValue,float.MinValue);
            float closestDistance = float.PositiveInfinity;
            foreach (List<Vector2> poly in vector)
            {
                foreach (Vector2 v in poly)
                {
                    if (getDistanceSquared(v, point) < closestDistance)
                    {
                        closestDistance = getDistanceSquared(v, point);
                        currentClosest = v;
                    }
                }
            }
            return currentClosest;
        }
        private static float getDistanceSquared(Vector2 p1, Vector2 p2)
        {
            return (float)(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
        public static List<List<Vector2>> getCollisionPolygons(Vector2 point1, Vector2 point2, CollisionType type = CollisionType.unitCollision, float offset = 1, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<List<Vector2>>(){ new List<Vector2>() { point1,point2,new Vector2(point2.X+1,point2.Y+1) } };
            return getCollisionPolygons(list, type, offset, offsetType);
        }
        public static List<List<Vector2>> getCollisionPolygons(Vector2 point, CollisionType type = CollisionType.unitCollision, float offset = 1, OffsetType offsetType = OffsetType.round)
        {
            var list = new List < List < Vector2 >>(){new List<Vector2>() {point, new Vector2(point.X + 1, point.Y + 1) , new Vector2(point.X -1, point.Y + 1) } };
            return getCollisionPolygons(list, type, offset, offsetType);

        }
        public static List<List<Vector2>> getCollisionPolygons(List<List<Vector2>> polygons, CollisionType type=CollisionType.unitCollision, float offset = 1, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p1 = PolygonHelperClass.VectorsToPolys(polygons);
            
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(p1, offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(p1, offset);
            }
            else
            {
                return null;
            }
            PolygonSet p2;
            if (type == CollisionType.unitCollision)
            {
                p2 = PremadePolygonSets.unitCollision;
            }
            else if (type == CollisionType.visionCollision)
            {
                p2 = PremadePolygonSets.visionCollision;
            }
            else if (type == CollisionType.bushCollision)
            {
                p2 = PremadePolygonSets.bushCollision;
            }
            else
            {
                return null;
            }
            return PolygonHelperClass.PolysToVectors(getCollisionPolygonSet(p, p2));

        }
        private static class PolygonHelperClass
        {
            public static List<Vector2> PolyToVector(Polygon polygon)
            {
                var v1 = new List<Vector2>();
                foreach (IntPoint point in polygon)
                {
                    v1.Add(new Vector2(point.X,point.Y));
                }
                return v1;
            }
            public static List<IntPoint> VectorToPoly(List<Vector2> vector)
            {
                var p1 = new Polygon();
                foreach (Vector2 v in vector)
                {
                    p1.Add(new IntPoint((int)v.X, (int)v.Y));
                }
                return p1;
            }
            public static List<List<Vector2>> PolysToVectors(PolygonSet polygons)
            {
                var v1 = new List<List<Vector2>>();
                foreach (Polygon p in polygons)
                {
                    v1.Add(PolyToVector(p));
                }
                return v1;
            }
            public static List<List<IntPoint>> VectorsToPolys(List<List<Vector2>> vectors)
            {
                var p1 = new PolygonSet();
                foreach (List<Vector2> v in vectors)
                {
                    p1.Add(VectorToPoly(v));
                }
                return p1;
            }
        }
        public enum CollisionType
        {
            visionCollision, unitCollision, bushCollision
        };
        public enum OffsetType
        {
            round, square
        };
        private static class Generate
        {
            public static PolygonSet offsetLineRound(PolygonSet p, float d)
            {
                ClipperOffset co = new ClipperOffset();
                co.AddPaths(p, JoinType.jtRound, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
            public static PolygonSet offsetLineSquare(PolygonSet p, float d)
            {
                ClipperOffset co = new ClipperOffset();
                co.AddPaths(p, JoinType.jtSquare, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
        }
        private static class PremadePolygonSets
        {
            public static PolygonSet unitCollision = StorageClass.unitCollision;
            public static PolygonSet visionCollision = StorageClass.visionCollision;
            public static PolygonSet bushCollision = StorageClass.bushCollision;
            public static float[] heightData = StorageClass.heightData;
        }
	}
}

