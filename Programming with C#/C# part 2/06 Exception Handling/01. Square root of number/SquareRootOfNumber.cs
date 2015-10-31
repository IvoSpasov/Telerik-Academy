// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
// Use try-catch-finally.

using System;

class SquareRootOfNumber
{
    static void Main()
    {
        Console.WriteLine("This program calculates the square root of an integer number.");
        Console.Write("Please type in a number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArithmeticException();
            }
            double result = Math.Sqrt(number);
            Console.WriteLine("The result is: {0:F2}", result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
}
