// Write a method that checks if the element at given position in given array of integers is bigger than its 
// two neighbors (when such exist).


using System;

class ElementCompare
{
    static void BiggerThanNeighbours(int position, double[] array)
    {
        if (array.Length <= 1)
        {
            Console.WriteLine("There is only one element in the array.");
        }

        else if (position >= 0 && position != 0 && position != array.Length - 1 && position < array.Length)
        {
            if (array[position - 1] < array[position] && array[position] > array[position + 1])
            {
                Console.WriteLine("This element is bigger than its neighbours.");
            }
            else
            {
                Console.WriteLine("This element is smaller than at least one of its neighbours.");
            }
        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("The first element is bigger than the second one.");
            }
            else
            {
                Console.WriteLine("The first element is smaller than the second one.");
            }
        }
        else if (position == array.Length - 1)
        {
            if (array[position - 1] < array[position])
            {
                Console.WriteLine("The last element is bigger than the one before it.");
            }
            else
            {
                Console.WriteLine("The last element is smaller than the one before it.");
            }
        }
        else
        {
            Console.WriteLine("Invalid position.");
        }
    }

    static void Main()
    {
        double[] randomArray = { 1.1, 2.5, 3.789, 4, 7.6, 3.25, 7, 8, 2, 5, 6, 45 };
        int randomPosition = 4;
        BiggerThanNeighbours(randomArray, randomPosition);
    }
}