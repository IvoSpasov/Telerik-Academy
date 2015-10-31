// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;

class PalindromeCheck
{
    static void Main()
    {
        string text = "ABBA was a Swedish pop group formed in Stockholm in 1972." +
            "Isabelle Lamal was an American film actress. The Honda Civic is a line" +
            " of subcompact and subsequently compact cars made and manufactured by Honda." +
            "Back in the day, the four-rotor 13J engine would have been good for 9000 rpm and" +
            " change, but we shift at 8500 to make sure we maximize our time between rebuilds";

        string[] separators = { " ", ",", ".", "-", "?" };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> resulst = new List<string>();

        foreach (var word in words)
        {
            string firstPart;
            string secondPart;
            if (word.Length % 2 != 0 && word.Length > 1)
            {
                firstPart = word.Substring(0, word.Length / 2).ToLower();
                secondPart = word.Substring(word.Length / 2 + 1).ToLower();
            }
            else // if(word.Length % 2 == 0)
            {
                firstPart = word.Substring(0, word.Length / 2).ToLower();
                secondPart = word.Substring(word.Length / 2).ToLower();
            }

            char[] secPartArray = secondPart.ToCharArray();
            Array.Reverse(secPartArray);
            secondPart = string.Join("", secPartArray);

            if (firstPart == secondPart)
            {
                resulst.Add(word);
            }
        }
        Console.WriteLine("The palindromes in the text are: ");
        Console.WriteLine(string.Join(", ", resulst));
    }
}
