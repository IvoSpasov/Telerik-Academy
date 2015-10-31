namespace Computers.Common.Interfaces
{
    public interface ICpu : IMotherboardComponent
    {
        byte NumberOfCores { get; }

        void GenerateRandomNumber(int minValue, int maxValue);

        void CalculateSquareNumber();
    }
}
