namespace Points
{
    public struct Point3D
    {
        private static readonly Point3D startPoint;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point3D StartPoint 
        {
            get
            {
                return startPoint;
            }
            private set
            {

            }
        }

        public Point3D(int pointX, int pointY, int pointZ) : this()
        {
            this.X = pointX;
            this.Y = pointY;
            this.Z = pointZ;
            StartPoint = new Point3D();
        }

        public override string ToString()
        {
            string template = "The coordinates of the point are x = {0}, y = {1}, z = {2}";
            string result = string.Format(template, this.X, this.Y, this.Z);
            return result;
        }
    }
}
