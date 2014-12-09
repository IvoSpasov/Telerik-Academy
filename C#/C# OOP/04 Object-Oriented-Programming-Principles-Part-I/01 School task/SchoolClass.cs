namespace _01_School_task
{
    public class SchoolClass : ICommentable
    {
        private string textIdentifier;
        private Teachers teacher;
        private Student student;
        private string comment;

        public SchoolClass(string className)
        {
            this.TextIdentifier = className;
        }

        public SchoolClass(string className, Teachers teacher, Student student)
            : this(className)
        {
            this.Teacher = teacher;
            this.Student = student;
        }

        // and there is your optional comment using a constructor
        public SchoolClass(string className, Teachers teacher, Student student, string anyComment)
            : this(className, teacher, student)
        {
            this.Comment = anyComment;
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            private set { this.textIdentifier = value; }
        }

        public Teachers Teacher
        {
            get { return this.teacher; }
            private set { this.teacher = value; }
        }

        public Student Student
        {
            get { return this.student; }
            private set { this.student = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            private set { this.comment = value; }
        }
    }
}
