namespace _03_Animals_task
{
    using System;
    using System.Collections.Generic;
    public abstract class Animals : ISound
    {
        public double Age { get; set; }

        public bool Male { get; set; }

        public string Name { get; set; }

        public abstract void MakeSound();

        public static double CalculateAverageAge(IList<Animals> listOfAnimals)
        {
            double sum = 0;

            foreach (var animal in listOfAnimals)
            {
                sum += animal.Age;
            }

            double result = sum / listOfAnimals.Count;
            return result;
        }
    }
}
