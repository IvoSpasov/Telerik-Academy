// Write a program that finds the most frequent number in an array. 
// Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class MostFrequentDigit
{
    static void Main()
    {
        int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int counter = 0;
        int bestCounter = int.MinValue;
        int bestNumber = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] == myArray[i])
                {
                    counter++;
                    if (bestCounter < counter)
                    {
                        bestCounter = counter;
                        bestNumber = myArray[i];
                    }
                }
            }
            counter = 0;
        }
        Console.WriteLine("{0} ({1} times)", bestNumber, bestCounter);
    }
}

