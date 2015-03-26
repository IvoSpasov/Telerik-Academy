namespace Computers.Common.Factories
{
    using System.Collections.Generic;

    using Computers.Common.Enums;
    using Computers.Common.Parts;

    public class HPComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            var ram = new RamMemory(2);
            var videoCard = new ColorVideoCard();
            var motherboard = new Motherboard(ram, videoCard);
            var cpu = new Cpu(2, NumberOfBits.Bit32, motherboard);

            var pc = new Pc(cpu, motherboard, new[] { new HardDrive(500, false, 0) });
            return pc;
        }

        public Server CreateServer()
        {
            var serverRam = new RamMemory(32);
            var serverVideoCard = new MonochromeVideoCard();
            var serverMotherboard = new Motherboard(serverRam, serverVideoCard);
            var serverCpu = new Cpu(4, NumberOfBits.Bit32, serverMotherboard);

            var server = new Server(serverCpu, serverMotherboard, new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) });
            return server;
        }

        public Laptop CreateLaptop()
        {
            var laptopVideoCard = new ColorVideoCard();
            var laptopRam = new RamMemory(4);
            var laptopMotherboard = new Motherboard(laptopRam, laptopVideoCard);
            var laptopCpu = new Cpu(2, NumberOfBits.Bit64, laptopMotherboard);

            var laptop = new Laptop(laptopCpu, laptopMotherboard, new[] { new HardDrive(500, false, 0) }, new LaptopBattery());
            return laptop;
        }
    }
}
