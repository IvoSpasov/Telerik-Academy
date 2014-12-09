namespace _02_Humans_task
{
    public class Student : Human
    {
        private int grade;

        public Student()
        {
        }

        public Student(string firstName)
            : base(firstName)
        {
        }

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            string template = "{0} {1} is in {2} grade.";
            string result = string.Format(template, this.FirstName.PadLeft(10), this.LastName.PadRight(10), this.Grade.ToString().PadLeft(2));
            return result;
        }
    }
}
