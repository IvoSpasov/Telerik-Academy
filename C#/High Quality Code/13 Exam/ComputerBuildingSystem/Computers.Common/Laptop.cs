namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class Laptop : Computer
    {
        public Laptop(Cpu cpu, IMotherboard motherboard, IEnumerable<HardDrive> hardDrives, IBattery battery)
            : base(cpu, motherboard, hardDrives)
        {
            this.Battery = battery;
        }

        public IBattery Battery { get; private set; }

        public void ChargeBattery(int percentage)
        {
            this.Battery.Charge(percentage);
            this.Motherboard.DrawOnVideoCard(string.Format("Battery status: {0}%", this.Battery.BatteryPercentage));
        }
    }
}
