namespace Computers.Common.Parts
{
    using System.Collections.Generic;

    using Computers.Common.Interfaces;

    public class HardDrive : IHardDrive
    {
        private readonly IDictionary<int, string> data;

        public HardDrive(int capacity)
        {
            this.Capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }

        public int Capacity { get; private set; }

        public void SaveData(int address, string newData)
        {
            this.data[address] = newData;
        }

        public string LoadData(int address)
        {
            return this.data[address];
        }
    }
}
