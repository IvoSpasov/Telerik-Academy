// Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. 
// Write a program to test whether the method works correctly.

namespace _04_MaximalSequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var testSequence = new List<int>() 
            {
                1, 1, 2, 3, 2, 2, 2, 2, 1, 1 
            };

            var result = FindMaximalEqualElements(testSequence);
            Console.WriteLine("The result is: " + string.Join(", ", result));
        }

        private static List<int> FindMaximalEqualElements(List<int> sequence)
        {
            int start = 0, bestStart = 0;
            int lenght = 1, maximalLenght = 1;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    // Increase lenght everytime you see two equal numbers (one after another).
                    lenght++;

                    if (lenght == 2)
                    {
                        // Update start only if you are in the beggining of a sequence. 
                        start = i;
                    }

                    // If you find longer sequence -> update...
                    if (lenght > maximalLenght)
                    {
                        // ...the lenght...
                        maximalLenght = lenght;

                        // ...and the start of it.
                        bestStart = start;
                    }
                }
                else
                {
                    // If you don't have two equal numbers (one after another), reset lenght.
                    lenght = 1; 
                }
            }

            return new List<int>(sequence.GetRange(bestStart, maximalLenght));
        }
    }
}
