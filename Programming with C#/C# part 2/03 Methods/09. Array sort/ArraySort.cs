// Write a method that returns the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.

using System;

class ArraySort
{
    static int GreaterElementInRange(int indexStart, int[] array)
    {
        int greaterElement = int.MinValue;
        int greaterElementIndex = 0;

        for (int i = indexStart; i < array.Length; i++)
        {
            if (array[i] > greaterElement)
            {
                greaterElement = array[i];
                greaterElementIndex = i;
            }
        }

        return greaterElementIndex;
    }

    static int[] SortArray(int[] array, int order)
    {
        int valueAtFirstIndex = 0;
        int secondIndex = 0;
        int[] backUpArray = (int[])array.Clone();
        
        for (int firstIndex = 0; firstIndex < array.Length; firstIndex++)
        {
            valueAtFirstIndex = array[firstIndex];
            secondIndex = GreaterElementInRange(firstIndex, array);
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = valueAtFirstIndex;
        }
        // if order == 1 -> Ascending
        if (order == 1)
        {
            Array.Reverse(array);
            return array;
        }
        // if order == 2 -> Descending
        else if (order == 2)
        {
            return array;
        }
        else
        {
            Console.WriteLine("No sorting was performed.");
            return backUpArray;
        }
    }

    static void Main()
    {
        int[] randomArray = { 1, 0, 8, 3, 2, 5, 20, -50, -15161, 5068, 9 };
        Console.WriteLine("This program sorts an array in ascending or descending order.");
        Console.Write("Please type in \"1\" for ascending or \"2\" for descending oreder: ");
        int order = int.Parse(Console.ReadLine());
        randomArray = SortArray(randomArray, order);
        Console.WriteLine(string.Join(", ", randomArray));
    }
}