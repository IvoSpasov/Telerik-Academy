namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const string ModelNullOrEmptyErrorMessage = "The model of the furniture cannot be null or empty";
        private const int ModelMinimumLength = 3;
        private const string ModelMinimumLengthErrorMessage = "The model must be at least {0} symbols long";
        private const int Zero = 0;
        private const string PriceZeroOrLessErrorMessage = "The price cannot be less than or equal to {0}";
        private const string HeightZeroOrLessErrorMessage = "The height cannot be less than or equal to {0}";

        private readonly MaterialType material;
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ModelNullOrEmptyErrorMessage);
                }

                if (value.Length < ModelMinimumLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format(ModelMinimumLengthErrorMessage, ModelMinimumLength));
                }

                this.model = value;
            }
        }

        public string Material
        {
            get 
            {
                return this.material.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= Zero)
                {
                    throw new ArgumentException(string.Format(PriceZeroOrLessErrorMessage, Zero));
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }

            set
            {
                if (value < Zero)
                {
                    throw new ArgumentOutOfRangeException(string.Format(HeightZeroOrLessErrorMessage, Zero));
                }

                this.height = value;
            }
        }
    }
}
