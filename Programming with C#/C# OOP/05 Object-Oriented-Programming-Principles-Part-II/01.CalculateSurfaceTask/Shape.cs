namespace _01.CalculateSurfaceTask
{
    public abstract class Shape
    {
        private double widht;
        private double height;

        public double Width 
        {
            get { return this.widht; }
            set { this.widht = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public abstract double CalculateSurface();

    }
}
