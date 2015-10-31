namespace Computers.Common.Factories
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class DellComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            return new Pc(
                new Cpu64Bit(4),
                new RamMemory(8),
                new[] { new HardDrive(1000) },
                new ColorfulVideoCard());
        }

        public Server CreateServer()
        {
            return new Server(
                new Cpu64Bit(8),
                new RamMemory(64),
                new List<IHardDrive>
                    {
                        new RaidArray(new List<IHardDrive> { new HardDrive(2000), new HardDrive(2000) })
                    });
        }

        public Laptop CreateLaptop()
        {
            return new Laptop(
                new Cpu32Bit(4),
                new RamMemory(8),
                new[] { new HardDrive(1000) },
                new ColorfulVideoCard(),
                new LaptopBattery());
        }
    }
}
