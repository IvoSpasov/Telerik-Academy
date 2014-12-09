namespace _01.CalculateSurfaceTask
{
    using System;

    public class Circle : Shape
    {
        public Circle(double diameter)
        {
            base.Height = diameter;
            base.Width = diameter;
        }

        public override double CalculateSurface()
        {
            double radius = base.Width / 2;
            return Math.PI * radius * radius;
        }
    }
}
