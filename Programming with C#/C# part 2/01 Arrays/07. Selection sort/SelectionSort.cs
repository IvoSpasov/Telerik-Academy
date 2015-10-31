// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
// Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the
// smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int[] myArray = { 5, 3, 1, 4, 6, 15, 1, 2, 4, -5, 0, -2026 };
        int tempIndex = 0;

        for (int i = 0; i < myArray.Length - 1; i++)
        {
            int tempValue = int.MaxValue;
            for (int j = i; j < myArray.Length; j++)
            {
                if (myArray[j] < tempValue)
                {
                    tempValue = myArray[j];
                    tempIndex = j;
                }
            }

            myArray[tempIndex] = myArray[i];
            myArray[i] = tempValue;
        }

        // Print out
        string result = string.Join(", ", myArray);
        Console.WriteLine(result);
    }
}