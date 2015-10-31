namespace _03_Animals_task
{
   public class TomCat : Cat, ISound
    {
        public TomCat()
        {
            this.Male = true;
        }

        public TomCat(string name, double age)
            : this()
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
