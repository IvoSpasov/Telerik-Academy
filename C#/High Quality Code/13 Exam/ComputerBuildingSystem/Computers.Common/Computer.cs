namespace Computers.Common
{
    using System;
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public abstract class Computer
    {
        public Computer(Cpu cpu, IMotherboard motherboard, IEnumerable<HardDrive> hardDrives)
        {
            this.Cpu = cpu;
            this.Motherboard = motherboard;
            this.HardDrives = hardDrives;
        }

        // TODO: Change to ICpu
        public Cpu Cpu { get; private set; }

        public IMotherboard Motherboard { get; private set; }

        public IEnumerable<HardDrive> HardDrives { get; private set; }
    }
}
