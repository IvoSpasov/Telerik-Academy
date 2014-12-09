using System;
using System.Threading;
using System.Globalization;

class CircleRectanglePoint
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        float x1, y1, r, xOffSet, yOffSet; //Variables used for the circle.
        float width, height, top, bottom, left, right; // Variables used for the rectangle.
        float x, y; //Variables for the coordinates of the point that will be checkd later.
        //They'll be used both by the circle and the rectangle.

        r = 3.0f;
        xOffSet = 1.0f;
        yOffSet = 1.0f;     //Here we initialize the variables used for the circle.

        width = 6.0f;
        height = 2.0f;
        top = 1.0f;
        bottom = top - height;
        left = -1.0f;
        right = left + width;   //Here we initialize the variables used for the rectangle.

        Console.WriteLine("This program checks if a given point (x, y) is within a circle and outside of a\nrectangle. "
            + "They have predefined coordinates.");
        Console.Write("Please type in the x coordinate of the point: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Please type in the y coordinate of the point: ");
        y = float.Parse(Console.ReadLine());

        x1 = x - xOffSet;
        y1 = y - yOffSet;   //Here we calculate the position of the point coordinates according to the offset of the circle.

        if (((x1 * x1) + (y1 * y1) <= (r * r)) && (x < left || x > right || y < bottom || y > top))
        // And then we caclculate if the values of the coordinates are within the circle and outside of the rectangle.
        {
            Console.WriteLine("True. The point is within the circle and outside of the rectangle.");
        }
        else
        {
            Console.WriteLine("False. The point is NOT within the circle and outside of the rectangle.");
        }
    }
}

