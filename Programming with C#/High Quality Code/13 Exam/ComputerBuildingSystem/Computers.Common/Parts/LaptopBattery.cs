namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public class LaptopBattery : IBattery
    {
        private const int InitialPower = 50;
        private const int MaxPower = 100;
        private const int MinPower = 0;

        public LaptopBattery() 
        { 
            this.BatteryPercentage = InitialPower;
        }

        public int BatteryPercentage { get; private set; }

        public void Charge(int additialCharge)
        {
            this.BatteryPercentage += additialCharge;

            if (this.BatteryPercentage > MaxPower)
            {
                this.BatteryPercentage = MaxPower;
            }

            if (this.BatteryPercentage < MinPower)
            {
                this.BatteryPercentage = MinPower;
            }
        }
    }
}
