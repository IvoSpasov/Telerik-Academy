namespace CohesionAndCoupling
{
    using System;

    public class RectangularParallelepiped
    {
        private readonly IGeometryUtils geometryUtils;

        public RectangularParallelepiped(double width, double height, double depth, IGeometryUtils geometryUtils)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
            this.geometryUtils = geometryUtils;
        }

        public RectangularParallelepiped(double width, double height, double depth)
            : this(width, height, depth, new GeometryUtils()) 
        {
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = this.geometryUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = this.geometryUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = this.geometryUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = this.geometryUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}