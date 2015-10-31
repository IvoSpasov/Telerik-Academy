namespace _01.CalculateSurfaceTask
{
    public class Rectangle : Shape
    {
        public Rectangle(double widht, double height)
        {
            base.Width = widht;
            base.Height = height;
        }

        public override double CalculateSurface()
        {
            return base.Height * base.Width;
        }
    }
}
