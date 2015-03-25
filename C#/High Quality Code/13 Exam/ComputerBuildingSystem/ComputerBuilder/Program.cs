namespace ComputerBuilder
{
    using System;
    using System.Collections.Generic;

    using ComputerParts;
    using ComputerParts.Enums;

    public class Program
    {
        private const int Ram2gb = 2;
        private const int Ram4gb = 4;
        private const int Ram32gb = 32;
        private const byte Cpu2Core = 2;
        private const byte Cpu4Core = 4;

        public void Start()
        {
            Computer pc;
            Computer server;
            Computer laptop;

            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                var pcRam = new RamMemory(Ram2gb);
                var pcVideoCard = new ColorVideoCard();
                var pcMotherboard = new Motherboard(pcRam, pcVideoCard);
                var pcCpu = new Cpu(Cpu2Core, NumberOfBits.Bit32, pcMotherboard);

                pc = new Computer(ComputerType.Pc, pcCpu, pcMotherboard, new[] { new HardDrive(500, false, 0) }, null);

                var serverRam = new RamMemory(Ram32gb);
                var serverVideoCard = new MonochromeVideoCard();
                var serverMotherboard = new Motherboard(serverRam, serverVideoCard);
                var serverCpu = new Cpu(Cpu4Core, NumberOfBits.Bit32, serverMotherboard);

                server = new Computer(ComputerType.Server, serverCpu, serverMotherboard, new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) }, null);

                var laptopVideoCard = new ColorVideoCard();
                var laptopRam = new RamMemory(Ram4gb);
                var laptopMotherboard = new Motherboard(laptopRam, laptopVideoCard);
                var laptopCpu = new Cpu(Cpu2Core, NumberOfBits.Bit64, laptopMotherboard);

                laptop = new Computer(ComputerType.Laptop, laptopCpu, laptopMotherboard, new[] { new HardDrive(500, false, 0) }, new LaptopBattery());
            }
            //else if (manufacturer == "Dell")
            //{
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
            //}
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var currentLine = Console.ReadLine();

                if (currentLine == null)
                {
                }

                if (currentLine.StartsWith("Exit"))
                {
                }

                var cp = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
