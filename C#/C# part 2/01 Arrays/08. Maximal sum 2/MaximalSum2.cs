// Write a program that finds the sequence of maximal sum in given array. 
// Example:	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSum2
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int bestSum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;
        
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                for (int k = i; k <= j; k++)
                {
                    sum += myArray[k];  // Using 3 nested for loops I can go through all combinations of sums and... 

                    if (bestSum < sum)  // ...and simply check which is the biggest,
                    {
                        bestSum = sum;  
                        startIndex = i; // form where it starts
                        endIndex = k;   // and where it ends.
                    }

                }
                sum = 0; // clear sum
            }
        }

        // Print out
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(myArray[i] + ", ");
        }
        Console.WriteLine("\b\b "); // delete the last comma and go to a new line..
    }
}

