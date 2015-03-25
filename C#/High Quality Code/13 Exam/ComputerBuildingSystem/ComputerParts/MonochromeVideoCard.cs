namespace ComputerParts
{
    using System;

    using ComputerParts.Interfaces;

    public class MonochromeVideoCard : IVideoCard
    {
        public MonochromeVideoCard()
        {
        }

        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
