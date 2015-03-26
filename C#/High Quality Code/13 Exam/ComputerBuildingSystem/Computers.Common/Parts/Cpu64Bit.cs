namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public class Cpu64Bit : Cpu
    {
        private const int MaxNumber = 1000;

        public Cpu64Bit(byte numberOfCores, IMotherboard motherboard)
            : base(numberOfCores, motherboard)
        {
        }

        public override int GetMaxNumber()
        {
            return MaxNumber;
        }
    }
}
