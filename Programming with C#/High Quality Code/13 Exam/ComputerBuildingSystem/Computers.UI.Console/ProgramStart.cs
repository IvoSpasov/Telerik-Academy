namespace Computers.UI.Console
{
    using System;

    using Computers.Common;
    using Computers.Common.Enums;
    using Computers.Common.Factories;

    public class ProgramStart
    {
        private const string ExitCommand = "Exit";
        private const string ChargeCommand = "Charge";
        private const string ProcessCommand = "Process";
        private const string PlayCommand = "Play";

        public static void Main()
        {
            IComputerFactory computerManufacturer;
            string manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                computerManufacturer = ManufacturerFactory.GetFactory(Manufacturer.Hp);
            }
            else if (manufacturer == "Dell")
            {
                computerManufacturer = ManufacturerFactory.GetFactory(Manufacturer.Dell);
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            Pc pc = computerManufacturer.CreatePc();
            Server server = computerManufacturer.CreateServer();
            Laptop laptop = computerManufacturer.CreateLaptop();

            while (true)
            {
                var currentLine = Console.ReadLine();

                if (currentLine == null)
                {
                    break;
                }

                if (currentLine.StartsWith(ExitCommand))
                {
                    break;
                }

                var currentCommand = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentCommand.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var word = currentCommand[0];
                var number = int.Parse(currentCommand[1]);

                if (word == ChargeCommand)
                {
                    laptop.ChargeBattery(number);
                }
                else if (word == ProcessCommand)
                {
                    server.Process(number);
                }
                else if (word == PlayCommand)
                {
                    pc.Play(number);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
