// A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;

class Dictionary
{
    static void SearchForWord(string word)
    {
        string dictionayText = ".NET – platform for applications from Microsoft\n" +
                       "CLR – managed execution environment for .NET\n" +
                       "namespace – hierarchical organization of classes";
        string[] dictionaryRows = dictionayText.Split('\n');
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        for (int i = 0; i < dictionaryRows.Length; i++)
        {
            string[] separators = { "-", "–" };
            string[] separatedRows = dictionaryRows[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);

            dictionary.Add(separatedRows[0].Trim(), separatedRows[1].Trim());
        }

        string result = string.Empty;

        if (dictionary.TryGetValue(word, out result))
        {
            Console.WriteLine(word + " – " + result);
        }
        else
        {
            Console.WriteLine("Word not found.");
        }
    }

    static void Main()
    {
        SearchForWord("CLR");
        SearchForWord("Yahoo");
        SearchForWord("namespace");
    }
}
