namespace Computers.Common.Parts
{
    using Computers.Common.Interfaces;

    public abstract class MotherboardComponent : IMotherboardComponent
    {
        public IMotherboard Motherboard { get; set; }
    }
}
