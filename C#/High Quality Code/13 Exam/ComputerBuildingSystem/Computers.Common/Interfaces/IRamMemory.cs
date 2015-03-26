namespace Computers.Common.Interfaces
{
    public interface IRamMemory : IMotherboardComponent
    {
        int Amount { get; }

        void SaveValue(int newValue);

        int LoadValue();
    }
}
