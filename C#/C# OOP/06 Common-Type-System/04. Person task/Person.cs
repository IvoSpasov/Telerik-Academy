namespace _04.Person_task
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            string result = null;

            if (this.Age.HasValue)
            {
                result = this.Name + ", age: " + this.Age;
            }
            else
            {
                result = this.Name + ", age: unavailable";
            }

            return result;
        }
    }
}
