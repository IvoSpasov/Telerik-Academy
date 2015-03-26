namespace Computers.Common.Factories
{
    using System;

    public class DellComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            throw new NotImplementedException();
        }

        public Server CreateServer()
        {
            throw new NotImplementedException();
        }

        public Laptop CreateLaptop()
        {
            throw new NotImplementedException();
        }

        //    var ram = new RamMemory(Eight); var videoCard = new VideoCard() { IsMonochrome = false };
        //    pc = new Computer(Type.Pc, new Cpu(Eight / 2, 64, ram, videoCard), ram, new[] { new HardDrive(1000, false, 0) }, videoCard, null);
        //    var ram1 = new RamMemory(Eight * Eight);
        //    var card = new VideoCard(); 
        //    server = new Computer(Type.Server,
        //         new Cpu(Eight, 64, ram1, card),
        //         ram1,
        //         new List<HardDrive>{
        //                new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) })
        //            }, card, null); var ram2 = new RamMemory(Eight); var videoCard1 = new VideoCard() { IsMonochrome = false };
        //    laptop = new Computer(Type.Laptop,
        //        new Cpu(Eight / 2, ((32)), ram2, videoCard1),
        //        ram2,
        //        new[] { new HardDrive(1000, false, 0) },
        //        videoCard1,

        //        new Battery());
    }
}
