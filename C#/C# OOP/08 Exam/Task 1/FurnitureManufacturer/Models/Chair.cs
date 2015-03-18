namespace FurnitureManufacturer.Models
{
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
                "{0}, Legs: {1}",
                base.ToString(),
                this.NumberOfLegs);

            return result;
        }
    }
}