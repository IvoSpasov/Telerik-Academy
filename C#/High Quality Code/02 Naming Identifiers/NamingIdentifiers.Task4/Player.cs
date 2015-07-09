namespace NamingIdentifiers.Task4
{
    using System;

    public class Player
    {
        private string name;
        private int points;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points", "The value for points cannot be negative.");
                }

                this.points = value;
            }
        }
    }
}
