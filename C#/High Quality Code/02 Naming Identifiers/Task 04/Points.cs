namespace Task_04
{
    using System;

    public class Points
    {
        string name;
        int numberOfPoints;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfPoints
        {
            get
            {
                return this.numberOfPoints;
            }
            set
            {
                this.numberOfPoints = value;
            }
        }

        public Points()
        {
        }

        public Points(string name, int numberOfPoints)
        {
            this.Name = name;
            this.NumberOfPoints = numberOfPoints;
        }
    }
}
