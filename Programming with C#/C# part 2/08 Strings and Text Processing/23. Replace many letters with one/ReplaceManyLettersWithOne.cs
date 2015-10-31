// Write a program that reads a string from the console and replaces all series of consecutive 
// identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

using System;
using System.Text;

class ReplaceManyLettersWithOne
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i + 1])
            {
                result.Append(text[i]);
            }
        }
        result.Append(text[text.Length - 1]);
        Console.WriteLine("Before:");
        Console.WriteLine(text);
        Console.WriteLine("After:");
        Console.WriteLine(result.ToString());
    }
}