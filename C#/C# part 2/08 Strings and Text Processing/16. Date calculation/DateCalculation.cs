// Write a program that reads two dates in the format: day.month.year and calculates the 
// number of days between them. Example:
// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2006
// Distance: 4 days

using System;

class DateCalculation
{
    static void CalculateDays(DateTime firstDate, DateTime secondDate)
    {
        TimeSpan a = secondDate - firstDate;
        Console.WriteLine("There are {0} days between {1} and {2}.", a.Days,
            firstDate.ToShortDateString(), secondDate.ToShortDateString());
    }

    static void Main()
    {
        Console.WriteLine("This program calculates the days between two dates.");
        DateTime firstDate = DateTime.Parse("1.2.2014");
        DateTime secondDate = DateTime.Parse("3.2.2014");
        CalculateDays(firstDate, secondDate);

        Console.WriteLine("Now you can enter dates of your own.");
        DateTime thirdDate;
        Console.Write("Please enter the first date:");
        while (!(DateTime.TryParse(Console.ReadLine(), out thirdDate)))
        {
            Console.Write("Please enter the first date in the correct format:");
        }
        DateTime fourthDate;
        Console.Write("Please enter the second date:");
        while (!(DateTime.TryParse(Console.ReadLine(), out fourthDate)))
        {
            Console.Write("Please enter the second date in the correct format:");
        }
        CalculateDays(thirdDate, fourthDate);
    }
}
