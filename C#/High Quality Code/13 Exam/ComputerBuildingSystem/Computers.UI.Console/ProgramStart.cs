namespace ComputerBuilder
{
    using System;

    using Computers.Common;
    using Computers.Common.Factories;

    public class ProgramStart
    {
        public static void Main()
        {
            Pc pc;
            Server server;
            Laptop laptop;

            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                var hpComp = new HpComputers();
                laptop = hpComp.CreateLaptop();
                server = hpComp.CreateServer();
                pc = hpComp.CreatePc();
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
                    break;
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
