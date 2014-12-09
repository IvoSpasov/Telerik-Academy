namespace _03_Animals_task
{
    public class Kitten : Cat, ISound
    {
        public Kitten()
        {
            this.Male = false; // yes ... by default bool is folse but anyway I declare and initialize it
        }

        public Kitten(string name, double age)
            : this()
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
