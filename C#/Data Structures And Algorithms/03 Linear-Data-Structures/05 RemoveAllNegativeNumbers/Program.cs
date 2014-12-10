// Write a program that removes from given sequence all negative numbers.

namespace _05_RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var sequence = new List<int>()
            {
                1, 2, 3, -5, 4, -7
            };

            Console.WriteLine("Sequence before: " + string.Join(", ", sequence));
            int currentNumber;

            for (int i = 0; i < sequence.Count; i++)
            {
                currentNumber = sequence[i];
                if (currentNumber < 0)
                {
                    sequence.Remove(currentNumber);
                }
            }

            Console.WriteLine("Sequence after: " + string.Join(", ", sequence));
        }
    }
}