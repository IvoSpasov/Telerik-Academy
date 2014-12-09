namespace Points
{
    using System;

    public static class PointsCalculation
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            int distanceX = secondPoint.X - firstPoint.X;
            int distanceY = secondPoint.Y - firstPoint.Y;
            int distanceZ = secondPoint.Z - firstPoint.Z;
            double result = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
            return result;
        }
    }
}
