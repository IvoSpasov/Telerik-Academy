namespace Computers
{
    public class RamMemory
    {
        private int value; 

        public RamMemory(int maximumAmount)
        { 
            this.Amount = maximumAmount;
        } 

        public int Amount { get; set; } 

        public void SaveValue(int newValue)
        {
            value = newValue; 
        }

        public int LoadValue()
        {
            return value;
        }
    }
}