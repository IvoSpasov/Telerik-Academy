namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public class Chair : Furniture, IChair
    {
        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get;
            private set;
        }

        public override string ToString()
        {
            string result = string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name,
                this.Model,
                this.Material,
                this.Price,
                this.Height,
                this.NumberOfLegs);

            return result;
        }
    }
}