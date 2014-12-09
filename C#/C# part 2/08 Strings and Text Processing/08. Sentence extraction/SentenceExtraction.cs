// Write a program that extracts from a given text all sentences containing given word.
// Example: The word is "in". The text is:
// We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
// So we are drinking all the day. We will move out of it in 5 days.
// The expected result is:
// Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class SentenceExtraction
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else." +
            " Inside the submarine is very tight. So we are drinking all the day." +
            " We will move out of it in 5 days.";
        string word = "in";
        word = word.ToLower();
        string[] separators = { "." };
        string[] textAsArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> results = new List<string>();

        for (int i = 0; i < textAsArray.Length; i++)
        {
            if (Regex.IsMatch(textAsArray[i].ToLower(), @"\b" + word + @"\b"))
            {
                results.Add(textAsArray[i].Trim());
            }
        }

        Console.WriteLine("The input text is:");
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("The sentences which contain the word \"{0}\" are:", word);

        foreach (var sentence in results)
        {
            Console.WriteLine(sentence + ".");
        }
    }
}
