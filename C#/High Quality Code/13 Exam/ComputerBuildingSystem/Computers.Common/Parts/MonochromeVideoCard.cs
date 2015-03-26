namespace Computers.Common.Parts
{
    using System;

    using Computers.Common.Interfaces;

    public class MonochromeVideoCard : IVideoCard
    {
        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
