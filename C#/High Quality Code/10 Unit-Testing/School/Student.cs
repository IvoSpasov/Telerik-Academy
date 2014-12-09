namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int number;

        public Student(string studentName, int studentNumber)
        {
            this.Name = studentName;
            this.Number = studentNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "The student name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                if (value < 10000 || 99999 < value)
                {
                    throw new ArgumentOutOfRangeException("number", "The student number cannot be less than 10000 or more than 99999.");
                }

                this.number = value;
            }
        }
    }
}
