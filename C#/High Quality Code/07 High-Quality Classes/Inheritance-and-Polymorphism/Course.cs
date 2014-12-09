namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string courseName;

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("courseName", "The name of the course cannot be null or empty.");
                }

                this.courseName = value;
            }
        }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" { Name = " + this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
