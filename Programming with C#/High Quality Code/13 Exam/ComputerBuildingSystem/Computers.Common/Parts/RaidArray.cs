namespace Computers.Common.Parts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Computers.Common.Interfaces;

    public class RaidArray : IHardDrive
    {
        private readonly ICollection<IHardDrive> hardDrives;

        public RaidArray(ICollection<IHardDrive> hardDrives)
        {
            this.hardDrives = hardDrives;
        }

        public int Capacity
        {
            get
            {
                if (!this.hardDrives.Any())
                {
                    return 0;
                }

                return this.hardDrives.First().Capacity;
            }
        }

        public void SaveData(int address, string newData)
        {
            foreach (var disk in this.hardDrives)
            {
                disk.SaveData(address, newData);
            }
        }

        public string LoadData(int address)
        {
            if (!this.hardDrives.Any())
            {
                throw new InvalidOperationException("No hard drive in the RAID array!");
            }

            return this.hardDrives.First().LoadData(address);
        }
    }
}
