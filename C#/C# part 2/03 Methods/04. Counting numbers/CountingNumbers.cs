// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

using System;

class CountingNumbers
{
    static int CountNumbersInArray(double number, double[] arrayOfNumbers)
    {
        int counter = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        double[] randomArray = { 1.1, 2.5, 3.789, 4, 5, 6, 7, 8, 2, 5, 6, 45, 5, 5, 6, 5, 7, 98, 9, 5, 52, 2, 3, 6, 5, 4 };
        double randomNumber = 5;

        int result = CountNumbersInArray(randomNumber, randomArray);
        Console.WriteLine("The number \"{0}\" appears {1} times in our array.", randomNumber, result);
    }
}

