namespace _03_Animals_task
{
    using System;

    public class Frog : Animals, ISound
    {
        public Frog()
        {
        }

        public Frog(string name, double age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.Male = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ribbit");
        }
    }
}
