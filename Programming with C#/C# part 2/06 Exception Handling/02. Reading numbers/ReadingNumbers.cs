// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadingNumbers
{
    static int ReadNumber(int start, int end)
    {
        try
        {
            Console.WriteLine("Please enter a number between {0} and {1}.", start, end);
            int number = int.Parse(Console.ReadLine());
            if (!(start < number && number < end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is not between {0} and {1}.", start, end);
        }
        return start;
    }

    static void Main()
    {
        int min = 0;
        for (int i = 1; i <= 10; i++)
        {
            min = ReadNumber(min, 100); 
        }
    }
}