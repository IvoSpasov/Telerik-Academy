using System;
using System.Threading;
using System.Globalization;

    class PointWithinACircle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            float x, y, r, xOffset, yOffset;

            xOffset = 0.0f;   //Here you can change the offset of the circle in the program code.
            yOffset = 5.0f;   //Here you can change the offset of the circle in the program code.

            Console.WriteLine("This program checks if a given point with coordinates (x, y) is within a\ncircle or not." + 
                  "The circle itself has an offset with coordinates (0, 5).\nYou choose the radius of the circle and the" +
                  " point coordinates.");
            Console.WriteLine();
            Console.Write("Please type in the radius of the circle: ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Please type in the x coordinate of the point: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Please type in the y coordinate of the point: ");
            y = float.Parse(Console.ReadLine());

            x -= xOffset; // Here we calculate the position of the point coordinates according to the offset of the circle.
            y -= yOffset; // 

            if ((x*x) + (y*y) <= (r*r)) // And then we caclculate if the values of the coordinates are within the circle.
            {
                Console.WriteLine("True. The point is within the circle.");
            }
            else
            {
                Console.WriteLine("False. The point is outside the circle.");
            }
        }
    }

