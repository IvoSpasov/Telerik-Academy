// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

class ReverseTheSentence
{
    static void Main(string[] args)
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] separators = {",", "!", "."};
        string[] spaceSep = {" "};
        string[] separatedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(separatedText);

        StringBuilder result = new StringBuilder();
        result.Append(string.Join(", ", separatedText));

        for (int i = 0; i < separatedText.Length; i++)
        {
            string[] sentecePart = separatedText[i].Split(spaceSep, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(sentecePart);
            string reversed = string.Join(" ", sentecePart);
            result.Replace(separatedText[i], reversed);
        }
        Console.WriteLine("The original message is:");
        Console.WriteLine(text);
        Console.WriteLine("The result is:");
        Console.WriteLine(result.ToString() + "!");

    }
}

