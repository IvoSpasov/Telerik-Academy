namespace Computers.Common
{
    using System;
    using System.Collections.Generic;

    using Computers.Common.Interfaces;
    using Computers.Common.Parts;

    public abstract class Computer
    {
        public Computer(ICpu cpu, IRamMemory ram, IEnumerable<IHardDrive> hardDrives, IVideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Motherboard = new Motherboard(this.Cpu, this.Ram, this.VideoCard);
        }

        public IMotherboard Motherboard { get; private set; }

        public ICpu Cpu { get; private set; }

        public IRamMemory Ram { get; private set; }

        public IEnumerable<IHardDrive> HardDrives { get; private set; }

        protected IVideoCard VideoCard { get; private set; }
    }
}
