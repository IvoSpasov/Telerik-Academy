// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
// how many times each of them occurs.

namespace CountSimilarItems
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var collection = new int[] 
            {
                3, 4, 4, 2, 3, 3, 4, 3, 2
            };

            var result = CountSimilarNumbers(collection);
            foreach (var entry in result)
            {
                Console.WriteLine("{0} -> {1} times", entry.Key, entry.Value);
            }
        }

        private static Dictionary<int, int> CountSimilarNumbers(ICollection sequence)
        {
            var resultDictionary = new Dictionary<int, int>();
            int convertedNumber;

            foreach (var number in sequence)
            {
                convertedNumber = (int)number;
                if (!resultDictionary.ContainsKey(convertedNumber))
                {
                    resultDictionary.Add(convertedNumber, 1);
                }
                else
                {
                    resultDictionary[convertedNumber]++;
                }
            }

            return resultDictionary;
        }
    }
}
