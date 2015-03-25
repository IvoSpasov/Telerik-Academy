namespace ComputerParts
{
    public class Battery
    {
        public int Percentage { get; set; }

        public void Charge(int p)
        {
            Percentage += p;
            if (Percentage > 100) Percentage = 100;
            if (Percentage < 0) Percentage = 0;
        }

        public Battery() { this.Percentage = 100 / 2; }
    }
}
