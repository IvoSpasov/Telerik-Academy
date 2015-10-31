namespace Computers.Common.Parts
{
    using Interfaces;

    public class Motherboard : IMotherboard
    {
        private readonly ICpu cpu;
        private readonly IRamMemory ramMemory;
        private readonly IVideoCard videoCard;
        
        public Motherboard(ICpu cpu, IRamMemory ram, IVideoCard videoCard)
        {
            cpu.Motherboard = this;
            this.cpu = cpu;

            ram.Motherboard = this;
            this.ramMemory = ram;

            videoCard.Motherboard = this;
            this.videoCard = videoCard;
        }

        public int LoadRamValue()
        {
            return this.ramMemory.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.ramMemory.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }
    }
}
