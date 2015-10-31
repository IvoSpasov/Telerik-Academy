namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class Table : Furniture, ITable
    {
        public Table(string model, MaterialType material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get;
            private set;
        }

        public decimal Width
        {
            get;
            private set;
        }

        public decimal Area
        {
            get { return this.Length * this.Width; }
        }

        public override string ToString()
        {
            string result = string.Format(
                "{0}, Length: {1}, Width: {2}, Area: {3}",
                base.ToString(),
                this.Length,
                this.Width,
                this.Area);

            return result;
        }
    }
}
