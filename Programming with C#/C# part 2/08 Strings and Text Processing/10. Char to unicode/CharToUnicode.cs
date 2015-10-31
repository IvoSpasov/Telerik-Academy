// Write a program that converts a string to a sequence of C# Unicode character literals. 
// Use format strings. Sample input:
// Hi!
// Expected output:
// \u0048\u0069\u0021

using System;

class CharToUnicode
{
    static void Main()
    {
        string text = "Hi!";
        char[] textAsArray = text.ToCharArray();

        for (int i = 0; i < textAsArray.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)textAsArray[i]);
        }
        Console.WriteLine();
    }
}