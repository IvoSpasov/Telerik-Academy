namespace _01_School_task
{
    public class Disciplines : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Disciplines()
        {

        }

        public Disciplines(string nameOfDiscipline, int lectures, int exercises)
        {
            this.Name = nameOfDiscipline;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        // and there is your optional comment using a constructor
        public Disciplines(string nameOfDiscipline, int lectures, int exercises, string anyComment)
            : this(nameOfDiscipline, lectures, exercises)
        {
            this.Comment = anyComment;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set { this.numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set { this.numberOfExercises = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            private set { this.comment = value; }
        }
    }
}
