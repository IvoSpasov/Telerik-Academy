﻿namespace ComputerParts
{
    using System;

    using ComputerParts.Interfaces;

    public class ColorVideoCard : IVideoCard
    {
        public ColorVideoCard()
        {
        }

        public void Draw(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
