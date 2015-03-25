using System;

namespace Computers
{

    public class Cpu
    {
        private readonly byte numberOfCores;

        private readonly byte numberOfBits;

        private IMotherboard motherboard;

        private readonly Random randomGenerator;

        public Cpu(byte numberOfCores, byte numberOfBits, IMotherboard motherboard)
        {
            this.numberOfCores = numberOfCores;
            this.numberOfBits = numberOfBits;
            this.motherboard = motherboard;
            this.randomGenerator = new Random();
        }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32) SquareNumber32();
            if (this.numberOfBits == 64) SquareNumber64();
        }

        void SquareNumber32()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > 500)
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }
                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        void SquareNumber64()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > 1000)
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }
                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public void GenerateRandomNumberAndSaveItToRam(int minValue, int maxValue)
        {
            int randomNumber = this.randomGenerator.Next(minValue, maxValue);
            this.motherboard.SaveRamValue(randomNumber);
        }
    }
}
