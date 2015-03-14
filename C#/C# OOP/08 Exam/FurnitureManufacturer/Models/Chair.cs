namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class Chair : Furniture, IChair
    {
        private const string ToStringFormat = "{0}, Legs: {1}";

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
                ToStringFormat,
                base.ToString(),
                this.NumberOfLegs);

            return result;
        }
    }
}