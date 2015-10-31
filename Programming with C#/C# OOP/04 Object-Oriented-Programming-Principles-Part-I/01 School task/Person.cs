namespace _01_School_task
{
    public abstract class Person : ICommentable
    {
        private string name;
        private string comment;

        public Person(string hisName)
        {
            this.Name = hisName;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            protected set { this.comment = value; }
        }
    }
}
