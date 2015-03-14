namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public class ConvertableChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedChairHeight = 0.10m;
        private readonly decimal initialChairHeight;

        public ConvertableChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialChairHeight = height;
        }

        public bool IsConverted
        {
            get;
            private set;
        }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.IsConverted = false;
                this.Height = this.initialChairHeight;
            }
            else
            {
                this.IsConverted = true;
                this.Height = ConvertedChairHeight;
            }
        }
    }
}
