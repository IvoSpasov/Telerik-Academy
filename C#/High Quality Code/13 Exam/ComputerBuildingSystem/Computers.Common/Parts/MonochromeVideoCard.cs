namespace Computers.Common.Parts
{
    using System;

    using Computers.Common.Interfaces;

    public class MonochromeVideoCard : MotherboardComponent, IVideoCard
    {
        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
