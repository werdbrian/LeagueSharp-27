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
    using Polygon = System.Collections.Generic.List<IntPoint>;
    using PolygonSet = System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>;
    public static class NavMeshRemake
    {
        private static Vector2 getCollisionPointClosest(PolygonSet p1, PolygonSet p2, Vector2 point)
        {
            Clipper clipper = new Clipper();
            PolygonSet result = new PolygonSet();
            clipper.AddPaths(p1, PolyType.ptClip, true);
            clipper.AddPaths(p2, PolyType.ptSubject, true);
            bool succeeded = clipper.Execute(ClipType.ctIntersection, result, PolyFillType.pftPositive, PolyFillType.pftPositive);
            clipper.Clear();
            return getClosestPoint(result, new Vector2(point.X,point.Y));
        }
        private static Vector2 getClosestPoint(List<List<IntPoint>> vector, Vector2 point)
        {
            IntPoint p1 = new IntPoint(point.X, point.Y);
            IntPoint currentClosest = new IntPoint(0,0);
            bool success = false;
            float closestDistance = float.PositiveInfinity;
            foreach (List<IntPoint> poly in vector)
            {
                foreach (IntPoint v in poly)
                {
                    if (getDistanceSquared(v, p1) < closestDistance)
                    {
                        closestDistance = getDistanceSquared(v, p1);
                        currentClosest = v;
                        success = true;
                    }
                }
            }
            if (success)
            {
                return new Vector2(currentClosest.X, currentClosest.Y);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
        }
        private static float getDistanceSquared(IntPoint p1, IntPoint p2)
        {
            return (float)(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        //HEIGHT
        public static float getHeightForPosition(float x, float y)
        {
            if (x < 0 || x > 15000 || y < 0 || y > 15000) { return 0; }
            x /= 100;
            y /= 100;
            float indexFloat = x + y * 150;
            return StorageClass.heightData[(int)Math.Round(indexFloat)];
        }
        //POINT COLLISION
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 point1, CollisionType collisionType, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { point1, new Vector2(point1.X + 1, point1.Y + 1), new Vector2(point1.X - 1, point1.Y + 1) };
            return getClosestCollisionPoint(pivot, list, collisionType, offset, offsetType);

        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 point1, List<List<Vector2>> polygonSet, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { point1, new Vector2(point1.X + 1, point1.Y + 1), new Vector2(point1.X - 1, point1.Y + 1) };
            return getClosestCollisionPoint(pivot, list, polygonSet, offset, offsetType);
        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 point1, List<Vector2> v, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { point1, new Vector2(point1.X + 1, point1.Y + 1), new Vector2(point1.X - 1, point1.Y + 1) };
            return getClosestCollisionPoint(pivot, list, v, offset, offsetType);

        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 point1, Vector2 lineAStart, Vector2 lineAend, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { point1, new Vector2(point1.X + 1, point1.Y + 1), new Vector2(point1.X - 1, point1.Y + 1) };
            return getClosestCollisionPoint(pivot, lineAStart, lineAend, list, offset, offsetType);
        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 point1, Vector2 point2, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { point1, new Vector2(point1.X + 1, point1.Y + 1), new Vector2(point1.X - 1, point1.Y + 1) };
            return getClosestCollisionPoint(pivot, point2, list, offset, offsetType);
        }
        //LINE COLLISION
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 lineAStart, Vector2 lineAEnd, CollisionType collisionType, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>(){ lineAStart, lineAEnd, new Vector2(lineAEnd.X+1, lineAEnd.Y+1)};
            return getClosestCollisionPoint(pivot, list, collisionType, offset, offsetType);
        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 lineAStart, Vector2 lineAEnd, List<List<Vector2>> polygonSet, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { lineAStart, lineAEnd, new Vector2(lineAEnd.X + 1, lineAEnd.Y + 1) };
            return getClosestCollisionPoint(pivot, list, polygonSet, offset, offsetType);
        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 lineAStart, Vector2 lineAEnd, List<Vector2> v, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            var list = new List<Vector2>() { lineAStart, lineAEnd, new Vector2(lineAEnd.X + 1, lineAEnd.Y + 1) };
            return getClosestCollisionPoint(pivot, list, v, offset, offsetType);
        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, Vector2 lineAStart, Vector2 lineAEnd, Vector2 lineBStart, Vector2 lineBEnd, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p = new PolygonSet();
            var list = new List<IntPoint>() { new IntPoint(lineBStart.X, lineBStart.Y), new IntPoint(lineBEnd.X, lineBEnd.Y), new IntPoint(lineBEnd.X + 1, lineBEnd.Y + 1) };
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(list, offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(list, offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getClosestCollisionPoint(pivot, lineAStart, lineAEnd, offset, offsetType);
        }
        //POLYGON COLLISION
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, List<Vector2> polygon1, CollisionType collisionType, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            PolygonSet p2;
            if (collisionType == CollisionType.unitCollision)
            {
                p2 = PremadePolygonSets.unitCollision;
            }
            else if (collisionType == CollisionType.visionCollision)
            {
                p2 = PremadePolygonSets.visionCollision;
            }
            else if (collisionType == CollisionType.bushCollision)
            {
                p2 = PremadePolygonSets.bushCollision;
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getCollisionPointClosest(p, p2, pivot);

        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, List<Vector2> polygon1, List<List<Vector2>> polygonSet, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getCollisionPointClosest(p, PolygonHelperClass.VectorsToPolys(polygonSet), pivot);

        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, List<Vector2> polygon1, List<Vector2> polygon2, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(PolygonHelperClass.VectorToPoly(polygon1), offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }    
            return getCollisionPointClosest(p, new List<List<IntPoint>>() { PolygonHelperClass.VectorToPoly(polygon2) }, pivot);

        }
        //POLYGOTSET COLLISION
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, List<List<Vector2>> polygonSet1, CollisionType collisionType, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(PolygonHelperClass.VectorsToPolys(polygonSet1), offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(PolygonHelperClass.VectorsToPolys(polygonSet1), offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            PolygonSet p2;
            if (collisionType == CollisionType.unitCollision)
            {
                p2 = PremadePolygonSets.unitCollision;
            }
            else if (collisionType == CollisionType.visionCollision)
            {
                p2 = PremadePolygonSets.visionCollision;
            }
            else if (collisionType == CollisionType.bushCollision)
            {
                p2 = PremadePolygonSets.bushCollision;
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getCollisionPointClosest(p, p2, pivot);

        }
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, List<List<Vector2>> polygonSet1, List<List<Vector2>> polygonSet2, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p;
            if (offsetType == OffsetType.round)
            {
                p = Generate.offsetLineRound(PolygonHelperClass.VectorsToPolys(polygonSet1), offset);
            }
            else if (offsetType == OffsetType.square)
            {
                p = Generate.offsetLineSquare(PolygonHelperClass.VectorsToPolys(polygonSet1), offset);
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getCollisionPointClosest(p, PolygonHelperClass.VectorsToPolys(polygonSet2), pivot);

        }
        //COLLISIONTYPE COLLISION
        public static Vector2 getClosestCollisionPoint(Vector2 pivot, CollisionType collisionType1, CollisionType collisionType2, float offset = float.NaN, OffsetType offsetType = OffsetType.round)
        {
            PolygonSet p1;
            if (collisionType1 == CollisionType.unitCollision)
            {
                p1 = PremadePolygonSets.unitCollision;
            }
            else if (collisionType1 == CollisionType.visionCollision)
            {
                p1 = PremadePolygonSets.visionCollision;
            }
            else if (collisionType1 == CollisionType.bushCollision)
            {
                p1 = PremadePolygonSets.bushCollision;
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            PolygonSet p2;
            if (collisionType2 == CollisionType.unitCollision)
            {
                p2 = PremadePolygonSets.unitCollision;
            }
            else if (collisionType2 == CollisionType.visionCollision)
            {
                p2 = PremadePolygonSets.visionCollision;
            }
            else if (collisionType2 == CollisionType.bushCollision)
            {
                p2 = PremadePolygonSets.bushCollision;
            }
            else
            {
                return new Vector2(float.NaN, float.NaN);
            }
            return getCollisionPointClosest(p1, p2, pivot);

        }

        private static class PolygonHelperClass
        {
            public static List<Vector2> PolyToVector(Polygon polygon)
            {
                var v1 = new List<Vector2>();
                foreach (IntPoint point in polygon)
                {
                    v1.Add(new Vector2(point.X, point.Y));
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
            public static PolygonSet offsetLineRound(Polygon p, float d)
            {
                if (float.IsNaN(d)) { return new List<List<IntPoint>>() {p}; }
                ClipperOffset co = new ClipperOffset();
                co.AddPath(p, JoinType.jtRound, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
            public static PolygonSet offsetLineSquare(Polygon p, float d)
            {
                if (float.IsNaN(d)) { return new List<List<IntPoint>>() { p }; }
                ClipperOffset co = new ClipperOffset();
                co.AddPath(p, JoinType.jtSquare, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
            public static PolygonSet offsetLineRound(PolygonSet p, float d)
            {
                if (float.IsNaN(d)) { return p; }
                ClipperOffset co = new ClipperOffset();
                co.AddPaths(p, JoinType.jtRound, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
            public static PolygonSet offsetLineSquare(PolygonSet p, float d)
            {
                if (float.IsNaN(d)) { return p; }
                ClipperOffset co = new ClipperOffset();
                co.AddPaths(p, JoinType.jtSquare, EndType.etClosedPolygon);
                PolygonSet solution = new PolygonSet();
                co.Execute(ref solution, d);
                return solution;
            }
        }
        private static class PremadePolygonSets
        {
            public static PolygonSet unitCollision = StorageClass.unitCollisionPolygonSet;
            public static PolygonSet visionCollision = StorageClass.visionCollisionPolygonSet;
            public static PolygonSet bushCollision = StorageClass.bushCollisionPolygonSet;
        }
	}
}

