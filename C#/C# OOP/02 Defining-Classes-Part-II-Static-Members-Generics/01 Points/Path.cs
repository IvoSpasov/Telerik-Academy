namespace Points
{
    public class Path
    {
        private Point3D[] sequence;

        public Path(Point3D[] ArrayOfPoints)
        {
            this.Sequence = ArrayOfPoints;
        }

        public Point3D[] Sequence
        {
            get { return this.sequence; }
            set { this.sequence = value; }
        }
    }
}
