namespace Computers.Common
{
    using System;
    using System.Collections.Generic;

    using Computers.Common.Enums;
    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class Computer
    {
        public Computer(ComputerType type, Cpu cpu, IMotherboard motherboard, IEnumerable<HardDrive> hardDrives, IBattery battery)
        {
            this.Cpu = cpu;
            this.Motherboard = motherboard;
            this.HardDrives = hardDrives;
            this.Battery = battery;
        }

        public Cpu Cpu { get; private set; }

        public IMotherboard Motherboard { get; private set; }

        public IEnumerable<HardDrive> HardDrives { get; private set; }

        public IBattery Battery { get; private set; }

        public void ChargeBattery(int percentage)
        {
            this.Battery.Charge(percentage);
            this.Motherboard.DrawOnVideoCard(string.Format("Battery status: {0}%", this.Battery.BatteryPercentage));
        }

        public void Play(int guessNumber)
        {
            this.Cpu.GenerateRandomNumberAndSaveItToRam(1, 10);
            var number = this.Motherboard.LoadRamValue();
            if (number != guessNumber)
            {
                this.Motherboard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else 
            {
                this.Motherboard.DrawOnVideoCard("You win!"); 
            }
        }

        public void Process(int data)
        {
            this.Motherboard.SaveRamValue(data);
            this.Cpu.CalculateSquareNumber();
        }
    }
}
