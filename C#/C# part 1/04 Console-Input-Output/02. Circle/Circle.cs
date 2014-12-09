using System;
using System.Threading;
using System.Globalization;

    class Circle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            // This is so that you can use both "." and "," without getting an error message (unhandled exception).
            // But be careful because they don't do the same thing. The "," is just for better visual understanding of the number.

            double r, p, a;
            double pi = Math.PI;
            bool parseSuccess = true;
            
            Console.WriteLine("This program calculates the perimeter and area of a circle.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the radius of the circle in the correct format: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out r);
                }
                else
                {
                    Console.Write("Please type in the radius of the circle: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out r);    
                }
                
            } while (parseSuccess == false);
           
            p = 2 * pi * r;
            a = pi * r * r;

            Console.WriteLine("The perimeter of the circle is: {0:0.00}", p);
            Console.WriteLine("The area of the circle is: {0:0.00}", a);
        }
    }

