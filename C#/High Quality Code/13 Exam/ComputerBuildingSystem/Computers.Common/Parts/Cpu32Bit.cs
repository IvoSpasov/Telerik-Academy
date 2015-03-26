namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public class Cpu32Bit : Cpu
    {
        private const int MaxNumber = 500;

        public Cpu32Bit(byte numberOfCores, IMotherboard motherboard)
            : base(numberOfCores, motherboard)
        {
        }

        public override int GetMaxNumber()
        {
            return MaxNumber;
        }
    }
}
