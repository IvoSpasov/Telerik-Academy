namespace ComputerBuilder
{
    using System;
    using System.Collections.Generic;

    using ComputerParts;
    using ComputerParts.Enums;
    using ComputerParts.Interfaces;

    public class Computer
    {
        public Computer(ComputerType type, Cpu cpu, RamMemory ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard, Battery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Battery = battery;
        }

        public Cpu Cpu { get; set; }

        public RamMemory Ram { get; set; }

        public IEnumerable<HardDrive> HardDrives { get; set; }

        public IVideoCard VideoCard { get; set; }

        public Battery Battery { get; set; }

        public void ChargeBattery(int percentage)
        {
            this.Battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}", this.Battery.Percentage));
        }

        public void Play(int guessNumber)
        {
            Cpu.GenerateRandomNumberAndSaveItToRam(1, 10);
            var number = Ram.LoadValue();
            if (number != guessNumber)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else 
            {
                VideoCard.Draw("You win!"); 
            }
        }

        public void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.CalculateSquareNumber();
        }
    }
}
