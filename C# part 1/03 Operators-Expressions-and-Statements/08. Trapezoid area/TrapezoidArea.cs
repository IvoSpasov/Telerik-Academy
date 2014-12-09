using System;
using System.Threading;
using System.Globalization;


    class TrapezoidArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            double a, b, h;

            Console.WriteLine("This program calculates the area of a trapezoid by given sides " + 
                                "\"a\" and \"b\"\nand height \"h\".");
            Console.Write("Please type in the value of side \"a\": ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Please type in the value of side \"b\": ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Please type in the value of the height \"h\": ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is: {0:0.00}", ((a + b) * h / 2));
        }
    }

