// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
// if there’s no such element. Use the method from the previous exercise.

using System;

class IndexOfBiggerElement
{
    static bool BiggerThanNighbours(int position, double[] numbers)
    {
        bool check = false;
        if (numbers[position - 1] < numbers[position] && numbers[position] > numbers[position + 1])
        {
            check = true;
        }
        return check;
    }

    static void Main()
    {
        double[] randomArray = { 1.1, 2.5, 3.789, 4, 7.6, 3.25, 7, 8, 2, 5, 6, 45 };
        bool check = true;

        for (int index = 1; index < randomArray.Length - 1; index++)
        {
            if (BiggerThanNighbours(index, randomArray))
            {
                Console.WriteLine("The first element that is bigger than its neighbours has index: " + index);
                check = false;
                break;
            }
        }
        if (check)
        {
            Console.WriteLine("-1");
        }
    }
}