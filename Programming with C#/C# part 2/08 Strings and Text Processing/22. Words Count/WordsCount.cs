// Write a program that reads a string from the console and lists all different words in the 
// string along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void CoutWords(string text)
    {
        string[] separators = { ".", " ", ",", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string[] wordsArray = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> sortedWords = new SortedSet<string>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in wordsArray)
        {
            sortedWords.Add(word);
        }

        foreach (var word in sortedWords)
        {
            dict.Add(word, 0);
        }

        foreach (var word in wordsArray)
        {
            dict[word]++;
        }
        foreach (var word in dict.Keys)
        {
            Console.WriteLine("The word \"{0}\" is present {1} times.", word.PadLeft(10), dict[word]);
        }
    }

    static void Main()
    {
        string text = "1. Life isn’t fair, but it’s still good." +
        "2. When in doubt, just take the next small step." +
        "3. Life is too short to waste time hating anyone." +
        "4. Your job won’t take care of you when you are sick. Your friends and parents will. Stay in touch." +
        "5. Pay off your credit cards every month." +
        "6. You don’t have to win every argument. Agree to disagree." +
        "11. Make peace with your past so it won’t screw up the present.";
        CoutWords(text);

        Console.WriteLine("You can also enter your own text:");
        string text2 = Console.ReadLine();
        CoutWords(text2);
    }
}
