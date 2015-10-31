using System;

// In this second variant I use 3 methods instead of one. The idea is that it works faster if you don't perform sorting
// e.g. if you type different number than 1 and 2. It's probably more organized too.
// I'm also using "method overloading" i.e the methods have same names but different signautres.
// Pay attention that the 2-nd and 3-rd methods does not return any value i.e they are both "void". 
// I can do it in this way beacuse the "array" is "reference type".

class ArraySort2
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

    static void SortArray(int[] array) // This method returns the elements of the array sorted in descending order
    {
        int valueAtFirstIndex = 0;
        int secondIndex = 0;

        for (int firstIndex = 0; firstIndex < array.Length; firstIndex++)
        {
            valueAtFirstIndex = array[firstIndex];
            secondIndex = GreaterElementInRange(firstIndex, array);
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = valueAtFirstIndex;
        }
    }

    static void SortArray(int[] array, int order) // this method determines the order of the array
    {
        // if order == 1 -> Ascending
        if (order == 1)
        {
            SortArray(array);
            Array.Reverse(array);
        }
        // if order == 2 -> Descending
        else if (order == 2)
        {
            SortArray(array);
        }
        else
        {
            Console.WriteLine("No sorting was performed.");
        }
    }

    static void Main()
    {
        int[] randomArray = { 1, 0, 8, 3, 2, 5, 20, -50, -9 };
        Console.WriteLine("This program sorts an array in ascending or descending order.");
        Console.Write("Please type in \"1\" for ascending or \"2\" for descending oreder: ");
        int order = int.Parse(Console.ReadLine());
        SortArray(randomArray, order); 
        Console.WriteLine(string.Join(", ", randomArray));
    }
}
