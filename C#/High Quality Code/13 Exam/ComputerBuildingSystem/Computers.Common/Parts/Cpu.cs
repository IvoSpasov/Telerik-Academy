namespace Computers.Common.Parts
{
    using System;

    using Interfaces;

    public abstract class Cpu : MotherboardComponent, ICpu
    {
        private readonly Random randomGenerator;

        public Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
            this.randomGenerator = new Random();
        }

        public byte NumberOfCores { get; private set; }

        public void GenerateRandomNumber(int minValue, int maxValue)
        {
            int randomNumber = this.randomGenerator.Next(minValue, maxValue + 1);
            this.Motherboard.SaveRamValue(randomNumber);
        }

        public void CalculateSquareNumber()
        {
            int number = this.Motherboard.LoadRamValue();
            if (number < 0)
            {
                this.Motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (number > this.GetMaxNumber())
            {
                this.Motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int square = number * number;
                this.Motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", number, square));
            }
        }

        public abstract int GetMaxNumber();
    }
}
