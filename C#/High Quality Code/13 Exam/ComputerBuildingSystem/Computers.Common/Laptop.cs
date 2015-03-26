namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;

    public class Laptop : Computer
    {
        public Laptop(ICpu cpu, IRamMemory ram, IEnumerable<IHardDrive> hardDrives, IVideoCard videoCard, IBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
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
