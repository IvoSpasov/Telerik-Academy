// Write a program that counts in a given array of double values the number of occurrences of each value.
// Use Dictionary<TKey,TValue>.


namespace _01_CountingValues
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var collection = new double[] 
            {
                3, 4, 4, -2.5, 3, 3, 4, 3, -2.5
            };

            var result = CountSimilarNumbers(collection);
            foreach (var entry in result)
            {
                Console.WriteLine("{0} -> {1} times", entry.Key, entry.Value);
            }
        }

        private static Dictionary<double, int> CountSimilarNumbers(ICollection sequence)
        {
            var resultDictionary = new Dictionary<double, int>();
            double convertedNumber;

            foreach (var number in sequence)
            {
                convertedNumber = (double)number;
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
