namespace Computers.Common.Factories
{
    using System.Collections.Generic;

    using Computers.Common.Enums;
    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class HpComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            var ram = new RamMemory(2);
            var videoCard = new ColorfulVideoCard();
            var motherboard = new Motherboard(ram, videoCard);
            var cpu = new Cpu32Bit(2, motherboard);
            var hdd = new HardDrive(500);

            var pc = new Pc(cpu, motherboard, new[] { hdd });
            return pc;
        }

        public Server CreateServer()
        {
            var serverRam = new RamMemory(32);
            var serverVideoCard = new MonochromeVideoCard();
            var serverMotherboard = new Motherboard(serverRam, serverVideoCard);
            var serverCpu = new Cpu32Bit(4, serverMotherboard);
            var hdd1 = new HardDrive(1000);
            var hdd2 = new HardDrive(1000);
            var hddCollection = new List<IHardDrive>() { hdd1, hdd2 };
            var raid = new RaidArray(hddCollection);

            var server = new Server(serverCpu, serverMotherboard, new List<IHardDrive> { raid });
            return server;
        }

        public Laptop CreateLaptop()
        {
            var laptopVideoCard = new ColorfulVideoCard();
            var laptopRam = new RamMemory(4);
            var laptopMotherboard = new Motherboard(laptopRam, laptopVideoCard);
            var laptopCpu = new Cpu64Bit(2, laptopMotherboard);
            var hdd = new HardDrive(500);

            var laptop = new Laptop(laptopCpu, laptopMotherboard, new[] { hdd }, new LaptopBattery());
            return laptop;
        }
    }
}
