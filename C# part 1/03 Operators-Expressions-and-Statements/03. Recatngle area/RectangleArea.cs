using System;
using System.Threading;
using System.Globalization;

    class RectangleArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
            // This is so that you can use both "." and "," without getting an error message (unhandled exception).
            // But be careful because they don't do the same thing. The "," is just for better visual understanding of the number.

            decimal width, height;

            Console.WriteLine("This program calculates the area of a rectangle by given width and height.");
            Console.Write("Please type in the width of the rectangle: ");
            width = decimal.Parse(Console.ReadLine());
            Console.Write("Please type in the height of the rectangle: ");
            height = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is: {0:0.00}", width*height);

        }
    }

