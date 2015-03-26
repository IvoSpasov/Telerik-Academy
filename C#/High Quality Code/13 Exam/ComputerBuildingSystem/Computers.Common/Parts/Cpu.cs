namespace Computers.Common.Parts
{
    using System;

    using Computers.Common.Enums;
    using Interfaces;

    public abstract class Cpu
    {
        private readonly byte numberOfCores;
        private readonly IMotherboard motherboard;

        private readonly Random randomGenerator;

        public Cpu(byte numberOfCores, IMotherboard motherboard)
        {
            this.numberOfCores = numberOfCores;
            this.motherboard = motherboard;
            this.randomGenerator = new Random();
        }

        // separate to two methods for strong cohesion?
        public void GenerateRandomNumberAndSaveItToRam(int minValue, int maxValue)
        {
            int randomNumber = this.randomGenerator.Next(minValue, maxValue);
            this.motherboard.SaveRamValue(randomNumber);
        }

        public void CalculateSquareNumber()
        {
            int number = this.motherboard.LoadRamValue();
            if (number < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (number > this.GetMaxNumber())
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int square = number * number;
                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", number, square));
            }
        }

        public abstract int GetMaxNumber();
    }
}
