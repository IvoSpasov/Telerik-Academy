// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
using System;

class SequenceByGivenSum
{
    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8 }; 
        int tempSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        Console.Write("Please type in S: ");
        int sum = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                for (int k = i; k <= j; k++)
                {
                    tempSum += myArray[k];  // Using 3 nested for loops I can go through all combinations of sums and... 

                    if (tempSum == sum)  // ...and simply compare the combinations with the wanted one.
                    {
                        startIndex = i; // Save form where it starts
                        endIndex = k;   // and where it ends.
                    }

                }
                tempSum = 0; // clear sum
            }
        }

        // Print out
        if (sum != 0 && startIndex != endIndex)
        {
            Console.Write("The result is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b "); // delete the last comma and go to a new line.. 
        }
        else
        {
            Console.WriteLine("Sorry. There is no such sequence present.");
        }
    }
}

