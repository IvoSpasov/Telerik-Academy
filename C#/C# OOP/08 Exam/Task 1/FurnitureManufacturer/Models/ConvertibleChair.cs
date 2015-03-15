namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedChairHeight = 0.10m;
        private const string ToStringFormatAddition = "{0}, State: {1}";
        private const string ConvertedState = "Converted";
        private const string NormalState = "Normal";

        private readonly decimal nonConvertedHeight;

        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.nonConvertedHeight = height;
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
                this.Height = this.nonConvertedHeight;
            }
            else
            {
                this.Height = ConvertedChairHeight;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            string result = string.Format(
                ToStringFormatAddition, 
                base.ToString(),
                this.IsConverted ? ConvertedState : NormalState);

            return result;
        }
    }
}
