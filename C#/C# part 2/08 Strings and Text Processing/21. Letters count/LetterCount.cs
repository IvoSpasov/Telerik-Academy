// Write a program that reads a string from the console and prints all different letters in the 
// string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;

class LetterCount
{
    static void CountLetters(string text)
    {
        HashSet<char> letters = new HashSet<char>();
        SortedDictionary<char, int> sortedDict = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                letters.Add(text[i]);
            }
        }

        foreach (var letter in letters)
        {
            sortedDict.Add(letter, 0);
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (sortedDict.ContainsKey(text[i]))
            {
                sortedDict[text[i]]++;
            }
        }

        foreach (var letter in sortedDict.Keys)
        {
            Console.WriteLine("The letter \"{0}\" is present {1} times.", letter, sortedDict[letter]);
        }
    }

    static void Main()
    {
        string text = "1. Life isn’t fair, but it’s still good." +
            "2. When in doubt, just take the next small step." +
            "3. Life is too short to waste time hating anyone." +
            "4. Your job won’t take care of you when you are sick. Your friends and parents will. Stay in touch.";

        CountLetters(text);

        Console.WriteLine("You can also enter your own text:");
        string text2 = Console.ReadLine();
        CountLetters(text2);
    }
}
