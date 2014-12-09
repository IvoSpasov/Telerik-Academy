// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        int year = 0;

        Console.WriteLine("This program checks if a given year is a leap year.");
        Console.Write("Pease enter the year: ");
        while (!(int.TryParse(Console.ReadLine(), out year) && year > 0 && year < 9999))
        {
            Console.Write("Please enter a correct year: ");
        }

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}

