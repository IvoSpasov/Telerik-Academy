// Write a program that reads a list of words from a file words.txt and finds how many times each of 
// the words is contained in another file test.txt. The result should be written in the file result.txt 
// and the words should be sorted by the number of their occurrences in descending order. 
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        string line = string.Empty;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string[] separators = { " ", ",", "." };

        try
        {
            using (StreamReader input = new StreamReader("../../words.txt"))
            {
                while ((line = input.ReadLine()) != null)
                {
                    dictionary.Add(line.ToLower(), 0);
                }
            }
            List<string> keys = new List<string>(dictionary.Keys);

            using (StreamReader input = new StreamReader("../../test.txt", Encoding.GetEncoding("Windows-1251")))
            {
                while ((line = input.ReadLine()) != null)
                {
                    string[] lineSplit = line.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < lineSplit.Length; i++)
                    {
                        for (int j = 0; j < dictionary.Count; j++)
                        {
                            if (lineSplit[i] == keys[j])
                            {
                                dictionary[keys[j]]++;
                            }
                        }
                    }
                }
            }

            using (StreamWriter output = new StreamWriter("../../result.txt", false, Encoding.GetEncoding("Windows-1251")))
            {

                foreach (KeyValuePair<string, int> item in dictionary.OrderByDescending(key => key.Value))
                {
                    output.WriteLine(item.Key + " " + item.Value);
                }
            }

            Console.WriteLine("Counting successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc);
        }
    }
}
