namespace _03_Animals_task
{
    using System;

    public class Dog : Animals, ISound
    {
        public Dog()
        {
        }

        public Dog(string name, double age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.Male = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("woof");
        }
    }
}
