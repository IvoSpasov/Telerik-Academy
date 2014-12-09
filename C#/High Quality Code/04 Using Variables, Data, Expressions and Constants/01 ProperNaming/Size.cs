namespace _01_ProperNaming
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }
    }
}
