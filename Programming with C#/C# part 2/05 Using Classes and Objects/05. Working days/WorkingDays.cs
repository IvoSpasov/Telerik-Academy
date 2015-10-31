// Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
// preliminary as array.

using System;
using System.Threading;
using System.Globalization;

class WorkingDays
{
    static int WokrDays(DateTime givenDate)
    {
        DateTime today = DateTime.Today;
        givenDate = givenDate.AddDays(1); // In this way I include the "givenDate". E.g. -> form 6.Jan.2014 to 13.Jan.2014 = 6 working days (not five).
        int daysToWork = 0;
        DateTime saturday = new DateTime(2014, 1, 4);
        DateTime sunday = new DateTime(2014, 1, 5);

        DateTime[] holidays = { new DateTime(2014, 1, 1), new DateTime(2014, 3, 3), new DateTime(2014, 4, 18),
                                    new DateTime(2014, 4, 21), new DateTime (2014, 5, 1), new DateTime(2014, 5, 2), 
                                    new DateTime(2014, 5, 5), new DateTime(2014, 5, 6), new DateTime(2014, 9, 22), 
                                    new DateTime(2014, 12, 24), new DateTime(2014, 12, 25), new DateTime(2014, 12, 26), 
                                    new DateTime(2014, 12, 31)};
        DateTime[] workingSaturndays = { new DateTime(2014, 5, 10), new DateTime(2014, 12, 13) };



        while (today != givenDate)
        {
            if ((today.DayOfWeek != saturday.DayOfWeek && today.DayOfWeek != sunday.DayOfWeek) ||
                (today == workingSaturndays[0] || today == workingSaturndays[1]))
            {
                daysToWork++;
            }

            // This is one way to look for holidays.
            //for (int i = 0; i < holidays.Length; i++)
            //{
            //    if (today == holidays[i])
            //    {
            //        daysToWork--;
            //    }
            //}

            // The other is to use binary search. It is the faster way to find elements in a sorted array.
            int index = Array.BinarySearch(holidays, today);

            if (index >= 0)
            {
                daysToWork--;
            }

            today = today.AddDays(1);
        }

        return daysToWork;
    }

    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("This program gives you the working days from today to a specific date.");
        Console.Write("Please type in the specific date: ");
        DateTime givenDate = new DateTime();
        while (!DateTime.TryParse(Console.ReadLine(), out givenDate))
        {
            Console.WriteLine("Please type in a valid date in the correct format (dd:mm:yyyy or yyyy:mm:dd): ");
        }

        int daysToWork = 0;

        daysToWork = WokrDays(givenDate);
        Console.WriteLine("There are {0} working days form {1} to {2}",
            daysToWork, DateTime.Today.ToShortDateString(), givenDate.ToShortDateString());
    }
}

