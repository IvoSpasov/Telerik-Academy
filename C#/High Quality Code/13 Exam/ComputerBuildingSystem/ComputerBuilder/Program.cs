
using ComputerParts;
using ComputerParts.Enums;
using System;
using System.Collections.Generic;

namespace ComputerBuilder
{
    public class Program
    {
        private const int Ram2gb = 2;

        private const byte Cpu2Core = 2;

        public void Start()
        {
            Computer pc;
            Computer server;
            Computer laptop;

            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                var pcRam = new RamMemory(Ram2gb);

                var pcVideoCard = new MonochromeVideoCard();

                var pcMotherboard = new Motherboard(pcRam, pcVideoCard);

                var pcCpu = new Cpu(Cpu2Core, NumberOfBits.Bit32, pcMotherboard);

                pc = new Computer(ComputerType.Pc, pcCpu, pcRam, new[] { new HardDrive(500, false, 0) }, pcVideoCard, null);

                //var serverRam = new RamMemory(Eight * 4);
                //var serverVideo = new IVideoCard();

                //server = new Computer(Type.Server, new Cpu(Eight / 2, 32, serverRam, serverVideo), serverRam, new List<HardDrive>{
                //            new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) })
                //        },
                //        serverVideo, null);
                //{
                //    var card = new VideoCard()
                //    {
                //        IsMonochrome
                //            = false
                //    };
                //    var ram1 = new RamMemory(Eight / 2);
                //    laptop = new Computer(
                //        Type.Laptop,
                //        new Cpu(Eight / 4, 64, ram1, card),
                //        ram1,
                //        new[]
                //            {
                //                new HardDrive(500,
                //                    false, 0)
                //            },
                //        card,
                //        new Battery());
                //}
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
                throw new InvalidArgumentException("Invalid manufacturer!"); 
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
                    //laptop.ChargeBattery(ca); 
                }
                else if (cn == "Process") 
                {
                    //server.Process(ca); 
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
        

        public class InvalidArgumentException : ArgumentException { public InvalidArgumentException(string message) : base(message) { } }
        const int Eight = 8;
    }
}
