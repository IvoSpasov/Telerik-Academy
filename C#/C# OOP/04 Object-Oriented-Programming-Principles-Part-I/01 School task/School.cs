namespace _01_School_task
{
    public class School
    {
        private SchoolClass schoolClass;

        public School()
        {

        }

        public School(SchoolClass schoolClass)
        {
            this.SchoolClass = schoolClass;
        }

        public SchoolClass SchoolClass
        {
            get { return this.schoolClass; }
            private set { this.schoolClass = value; }
        }
    }
}
