// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class SortedWords
{
    static void Main()
    {
        string words = "He who shall be last shall be sideways and smiling.";
        string[] separators = { " ", "." };
        string[] wordsAsArray = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(wordsAsArray);

        Console.WriteLine("Before:");
        Console.WriteLine(words);
        Console.WriteLine("After:");
        foreach (var word in wordsAsArray)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
