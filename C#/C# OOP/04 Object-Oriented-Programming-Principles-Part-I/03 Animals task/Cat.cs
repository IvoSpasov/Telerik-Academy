namespace _03_Animals_task
{
    using System;

    public abstract class Cat : Animals, ISound
    {
        public override void MakeSound()
        {
            Console.WriteLine("miaauuu");
        }
    }
}
