// Write a program that counts how many times each word from given text file words.txt appears in it. 
// The character casing differences should be ignored. The result words should be ordered by their number 
// of occurrences in the text. 

namespace _03_CountingWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                using (StreamReader input = new StreamReader("../../words.txt"))
                {
                    string line = string.Empty;
                    while ((line = input.ReadLine()) != null)
                    {
                        string[] separators = { " ", ",", ".", "-", "–", "?", "!" };
                        string[] lineSplit = line.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < lineSplit.Length; i++)
                        {
                            string currentWord = lineSplit[i];

                            if (!dictionary.ContainsKey(currentWord))
                            {
                                dictionary.Add(currentWord, 1);
                            }
                            else
                            {
                                dictionary[currentWord]++;
                            }
                        }
                    }
                }

                Console.WriteLine("Counting successful.");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: " + exc);
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }
    }
}
