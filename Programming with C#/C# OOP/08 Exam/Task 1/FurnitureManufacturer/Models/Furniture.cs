namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const int ModelMinimumLength = 3;

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
                    throw new ArgumentNullException("The model of the furniture cannot be null or empty");
                }

                if (value.Length < ModelMinimumLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The model must be at least {0} symbols long", ModelMinimumLength));
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
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format("The price cannot be less than or equal to {0}", 0));
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The height cannot be less than or equal to {0}", 0));
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", 
                this.GetType().Name, 
                this.Model,
                this.Material,
                this.Price,
                this.Height);

            return result;
        }
    }
}
