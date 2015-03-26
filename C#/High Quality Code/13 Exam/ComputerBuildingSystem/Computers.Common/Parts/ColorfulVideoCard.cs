namespace Computers.Common.Parts
{
    using System;

    using Computers.Common.Interfaces;

    public class ColorfulVideoCard : IVideoCard
    {
        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
