namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public class LaptopBattery : IBattery
    {
        private const int LaptopBatteryInitialPower = 50;

        public LaptopBattery() 
        { 
            this.BatteryPercentage = LaptopBatteryInitialPower;
        }

        public int BatteryPercentage { get; private set; }

        public void Charge(int additialCharge)
        {
            this.BatteryPercentage += additialCharge;

            if (this.BatteryPercentage > 100)
            {
                this.BatteryPercentage = 100;
            }

            if (this.BatteryPercentage < 0)
            {
                this.BatteryPercentage = 0;
            }
        }
    }
}
