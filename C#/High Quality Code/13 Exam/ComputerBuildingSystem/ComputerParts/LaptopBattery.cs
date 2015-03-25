namespace ComputerParts
{
    using ComputerParts.Interfaces;

    public class LaptopBattery : IBattery
    {
        private const int LaptopBatteryInitialPower = 50;

        public LaptopBattery() 
        { 
            this.BatterPercentage = LaptopBatteryInitialPower;
        }

        public int BatterPercentage { get; private set; }

        public void Charge(int additialCharge)
        {
            this.BatterPercentage += additialCharge;

            if (BatterPercentage > 100)
            {
                BatterPercentage = 100;
            }
            if (BatterPercentage < 0)
            {
                BatterPercentage = 0;
            }
        }
    }
}
