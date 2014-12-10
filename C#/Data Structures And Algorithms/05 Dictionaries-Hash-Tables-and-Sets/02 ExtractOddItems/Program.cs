// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. 

namespace _02_ExtractOddItems
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var stringSequence = new List<string>() 
            { 
                "C#", "SQL", "PHP", "PHP", "SQL", "SQL" 
            };

            var stringsCount = CountSimilarStrings(stringSequence);
            var result = RemoveAllEvenlyOccuring(stringSequence, stringsCount);
            Console.WriteLine("Original colletion: " + string.Join(", ", stringSequence));
            Console.WriteLine("Collection as a result: " + string.Join(", ", result));
        }

        private static Dictionary<string, int> CountSimilarStrings(IList<string> sequence)
        {
            var resultDictionary = new Dictionary<string, int>();

            foreach (var element in sequence)
            {
                if (!resultDictionary.ContainsKey(element))
                {
                    resultDictionary.Add(element, 1);
                }
                else
                {
                    resultDictionary[element]++;
                }
            }

            return resultDictionary;
        }

        private static HashSet<string> RemoveAllEvenlyOccuring(IList<string> sequence,
            Dictionary<string, int> stringsCount)
        {
            var result = new HashSet<string>(sequence);

            foreach (var entry in stringsCount)
            {
                if (result.Contains(entry.Key) && entry.Value % 2 == 0)
                {
                    result.Remove(entry.Key);
                }
            }

            return result;
        }
    }
}
