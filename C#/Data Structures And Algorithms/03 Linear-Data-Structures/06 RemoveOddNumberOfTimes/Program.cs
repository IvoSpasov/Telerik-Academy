// Write a program that removes from given sequence all numbers that occur odd number of times. Example:

namespace _06_RemoveOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var listSequence = new List<int>() 
            { 
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };

            listSequence.RemoveAll(n => n == 1);

            // var linkedListSequence = PopulateLinkedList(listSequence);
            var numbersCount = CountSimilarNumbers(listSequence);
            var result = RemoveAllOddOccuring(listSequence, numbersCount);
            Console.WriteLine("Original colletion: " + string.Join(", ", listSequence));
            Console.WriteLine("Collection as a result: " + string.Join(", ", result));
        }

        //private static LinkedList<int> PopulateLinkedList(List<int> sequence)
        //{
        //    var populatedResult = new LinkedList<int>();
        //    int currentValue;
        //    int sequenceLenght = sequence.Count;

        //    for (int i = 0; i < sequenceLenght; i++)
        //    {
        //        currentValue = sequence[i];

        //        if (i == 0)
        //        {
        //            populatedResult.AddFirst(currentValue);
        //        }
        //        else if (i == 1)
        //        {
        //            populatedResult.AddAfter(populatedResult.First, currentValue);
        //        }
        //        else if (i == sequenceLenght - 1)
        //        {
        //            populatedResult.AddLast(currentValue);
        //        }
        //        else
        //        {
        //            populatedResult.AddAfter(populatedResult.Last, currentValue);
        //        }                
        //    }

        //    return populatedResult;
        //}

        private static Dictionary<int, int> CountSimilarNumbers(IList<int> sequence)
        {
            var resultDictionary = new Dictionary<int, int>();

            foreach (var number in sequence)
            {
                if (!resultDictionary.ContainsKey(number))
                {
                    resultDictionary.Add(number, 1);
                }
                else
                {
                    resultDictionary[number]++;
                }
            }

            return resultDictionary;
        }

        private static IList<int> RemoveAllOddOccuring(IList<int> sequence,
            Dictionary<int, int> numbersCount)
        {
            var result = new List<int>(sequence);

            foreach (var entry in numbersCount)
            {
                if (result.Contains(entry.Key) && entry.Value % 2 != 0)
                {
                    result.RemoveAll(n => n == entry.Key);
                }
            }

            return result;
        }
    }
}
