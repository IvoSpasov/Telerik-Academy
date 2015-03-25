using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Computer
    {
        //public Computer(Type type, )


        public Computer(Type type, Cpu cpu, RamMemory ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard, Battery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;

            if (type != Type.Laptop && type != Type.Pc)
            {
                VideoCard.IsMonochrome = true;
            }

            this.Battery = battery;
        }



        public Cpu Cpu { get; set; }

        public RamMemory Ram { get; set; }

        public IEnumerable<HardDrive> HardDrives { get; set; }

        public VideoCard VideoCard { get; set; }

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
            Cpu.SquareNumber();
        }
    }
}
