namespace _01_School_task
{
    public class Teachers : Person
    {
        private Disciplines disciplines;

        public Teachers(string hisName)
            : base(hisName)
        {
            this.Disciplines = new Disciplines();
        }

        public Teachers(string hisName, Disciplines hisDisciplines)
            : this(hisName) // base or this is better? I'm gessing base but I'll leave it this way for now.
        {
            this.Disciplines = hisDisciplines;
        }

        // and there is your optional comment using a constructor
        public Teachers(string hisName, Disciplines hisDisciplines, string anyComment)
            : this(hisName, hisDisciplines)
        {
            base.Comment = anyComment;
        }

        public Disciplines Disciplines
        {
            get { return this.disciplines; }
            private set { this.disciplines = value; }
        }
    }
}
