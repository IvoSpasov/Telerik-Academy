namespace Computers.Common
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class Server : Computer
    {
        public Server(ICpu cpu, IRamMemory ram, IEnumerable<IHardDrive> hardDrives)
            : base(cpu, ram, hardDrives, new MonochromeVideoCard())
        {
        }

        public void Process(int data)
        {
            this.Motherboard.SaveRamValue(data);
            this.Cpu.CalculateSquareNumber();
        }
    }
}
