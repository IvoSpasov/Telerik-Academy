namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public class RamMemory : IRamMemory
    {
        private int value; 

        public RamMemory(int maximumAmount)
        { 
            this.Amount = maximumAmount;
        } 

        public int Amount { get; private set; } 

        public void SaveValue(int newValue)
        {
            this.value = newValue; 
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}