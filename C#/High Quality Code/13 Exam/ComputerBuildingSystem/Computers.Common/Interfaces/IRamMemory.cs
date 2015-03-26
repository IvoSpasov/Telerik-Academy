namespace Computers.Common.Interfaces
{
    public interface IRamMemory
    {
        int Amount { get; }

        void SaveValue(int newValue);

        int LoadValue();
    }
}
