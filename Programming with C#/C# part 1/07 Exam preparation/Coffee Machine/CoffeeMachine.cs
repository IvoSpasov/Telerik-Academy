using System;
using System.Threading;
using System.Globalization;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        double amount = double.Parse(Console.ReadLine()); //amoutn of money the developer has to put into the machine
        double price = double.Parse(Console.ReadLine()); // price of the drink
        double change = amount - price;
        double five = 0.05, ten = 0.10, twenty = 0.20, fifty = 0.50, lev = 1.00;
        double total;

        n1 *= five;
        n2 *= ten;
        n3 *= twenty;
        n4 *= fifty;
        n5 *= lev;
        total = n1 + n2 + n3 + n4 + n5; // total in the machine


        if ((change <= total) && (price <= amount)) // the maschine has enough change to give
        {
            total += price;
            total -= amount;
            Console.WriteLine("Yes {0:0.00}", total);
        }
        if (price > amount)
        {
            price -= amount;
            Console.WriteLine("More {0:0.00}", price);

        }
        if (change > total)
        {
            change -= total;
            Console.WriteLine("No {0:0.00}", change);
        }

    }
}



// Score 100/100