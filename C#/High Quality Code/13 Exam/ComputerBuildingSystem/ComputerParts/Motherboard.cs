namespace ComputerParts
{
    using Interfaces;

    public class Motherboard : IMotherboard
    {
        private RamMemory ramMemory;
        private IVideoCard videoCard;

        public Motherboard(RamMemory ram, IVideoCard videoCard)
        {
            this.ramMemory = ram;
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
