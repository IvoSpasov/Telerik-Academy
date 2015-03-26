namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class Server : Computer
    {
        public Server(Cpu cpu, IMotherboard motherboard, IEnumerable<HardDrive> hardDrives)
            : base(cpu, motherboard, hardDrives)
        {
        }

        public void Process(int data)
        {
            this.Motherboard.SaveRamValue(data);
            this.Cpu.CalculateSquareNumber();
        }
    }
}
