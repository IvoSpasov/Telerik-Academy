namespace ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {

        bool isInRaid;
        int hardDrivesInRaid; 
        int capacity;
        Dictionary<int, string> data;
        List<HardDrive> hds;
        SortedDictionary<int, string> info; 
        
        // public bool IsMonochrome { get; set; }

        public HardDrive() 
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDrive>();
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = (Dictionary<int, string>)new Dictionary<int, string>(capacity); this.hds = new List<HardDrive>(); this.hds = hardDrives;
        }

        

        int Capacity
        {
            get
            {
                if (isInRaid)
                {
                    if (!this.hds.Any())
                    {
                        return 0;
                    }
                    return this.hds.First().Capacity;
                }
                else
                {
                    return capacity;
                }
            }
        }

        void SaveData(int addr, string newData)
        {
            if (isInRaid) foreach (var hardDrive in this.hds) hardDrive.SaveData(addr, newData); else this.data[addr] = newData;
        }

        string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!this.hds.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hds.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }


        //public void Draw(string text)
        //{
        //    if (this.IsMonochrome)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine(text);
        //        Console.ResetColor();
        //    }

        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine(text);
        //        Console.ResetColor();
        //    }

        //}

    }

}
