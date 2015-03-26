namespace Computers.Common.Parts
{
    using System;

    using Computers.Common.Enums;
    using Interfaces;

    public class Cpu
    {
        private const int Cpu32BitHighBoundary = 500;
        private const int Cpu64BitHighBoundary = 1000;

        private readonly byte numberOfCores;
        private readonly NumberOfBits numberOfBits;
        private readonly IMotherboard motherboard;

        private readonly Random randomGenerator;

        public Cpu(byte numberOfCores, NumberOfBits numberOfBits, IMotherboard motherboard)
        {
            this.numberOfCores = numberOfCores;
            this.numberOfBits = numberOfBits;
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
            else if (number > this.ReturnNumberHighBoundaryForCpu())
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int square = number * number;
                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", number, square));
            }
        }

        private int ReturnNumberHighBoundaryForCpu()
        {
            switch (this.numberOfBits)
            {
                case NumberOfBits.Bit32: return Cpu32BitHighBoundary;
                case NumberOfBits.Bit64: return Cpu64BitHighBoundary;
                default: throw new ArgumentException("Invalid processor");
            }
        }
    }
}
