namespace _01_School_task
{
    public class Student : Person
    {
        private int numberInClass;

        public Student(string hisName)
            : base(hisName)
        {

        }

        public Student(string hisName, int classNumber)
            : this(hisName) // base or this is better? I'm gessing base but I'll leave it this way for now.
        {
            this.NumberInClass = classNumber;
        }

        // and there is your optional comment using a constructor
        public Student(string hisName, int classNumber, string anyComment)
            : this(hisName, classNumber)
        {
            base.Comment = anyComment;
        }

        public int NumberInClass
        {
            get { return this.numberInClass; }
            private set { this.numberInClass = value; }
        }
    }
}
