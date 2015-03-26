namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class Pc : Computer
    {
        public Pc(Cpu cpu, IMotherboard motherboard, IEnumerable<HardDrive> hardDrives)
            : base(cpu, motherboard, hardDrives)
        {
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
    }
}
