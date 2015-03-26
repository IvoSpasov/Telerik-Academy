namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;

    public class Pc : Computer
    {
        public Pc(ICpu cpu, IRamMemory ram, IEnumerable<IHardDrive> hardDrives, IVideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            this.Cpu.GenerateRandomNumber(1, 10);
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
    }
}
