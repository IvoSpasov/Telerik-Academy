// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

class MaximalSequence
{
    static void Main()
    {
        int[] array = { 1, 1, 2, 3, 2, 2, 2, 1, 1 };
        int start = 0, bestStart = 0;
        int lenght = 1, maximalLenght = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                lenght++;  // Increase lenght everytime you see two equal numbers (one after another).

                if (lenght == 2)
                {
                    start = i; // Update start only if you are in the beggining of a sequence. 
                }
                if (lenght > maximalLenght) // If you find longer sequence -> update...
                {
                    maximalLenght = lenght; // ...the lenght...
                    bestStart = start; // ...and the start of it.
                }
            }
            else
            {
                lenght = 1; // If you don't have two equal numbers (one after another), reset lenght.
            }

        }
        Console.Write("The maximal sequence of equal elements is: {");
        for (int i = bestStart; i < bestStart + maximalLenght; i++) // Print the result
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine("\b\b}");
    }
}