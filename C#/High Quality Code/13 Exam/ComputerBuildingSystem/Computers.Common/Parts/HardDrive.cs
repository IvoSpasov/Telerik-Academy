namespace Computers.Common.Parts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        private readonly int capacity;

        private bool isInRaid;
        private int numberOfHardDrivesInRaid; 
        
        private Dictionary<int, string> data;

        private List<HardDrive> raidArray;

        public HardDrive() 
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.capacity = capacity;

            this.isInRaid = isInRaid;
            this.numberOfHardDrivesInRaid = hardDrivesInRaid;

            this.data = new Dictionary<int, string>(capacity);
            this.raidArray = new List<HardDrive>();
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.numberOfHardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.raidArray = hardDrives;
        }        

        public int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.raidArray.Any())
                    {
                        return 0;
                    }

                    return this.raidArray.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        public void SaveData(int address, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.raidArray) 
                {
                    hardDrive.SaveData(address, newData);
                }
            }
            else
            {
                this.data[address] = newData;
            }
        }

        public string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.raidArray.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.raidArray.First().LoadData(address);
            }
            else
            {
                return this.data[address];
            }
        }
    }
}
