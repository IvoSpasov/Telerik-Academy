namespace Computers.Common.Factories
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public class HpComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            return new Pc(
                new Cpu32Bit(2), 
                new RamMemory(2),
                new[] { new HardDrive(500) },
                new ColorfulVideoCard());
        }

        public Server CreateServer()
        {
            return new Server(
                 new Cpu32Bit(4),
                 new RamMemory(32),
                 new List<IHardDrive>
                    {
                        new RaidArray(new List<IHardDrive> { new HardDrive(1000), new HardDrive(1000) })
                    });
        }

        public Laptop CreateLaptop()
        {
            return new Laptop(
               new Cpu64Bit(2),
               new RamMemory(4),
               new[] { new HardDrive(500) },
               new ColorfulVideoCard(),
               new LaptopBattery());
        }
    }
}
