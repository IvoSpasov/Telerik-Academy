using System;

    class GreatestOfFive
    {
        static void Main()
        {
            int a = 6, b = 7, c = 8, d = 9, e = 5, temp;

            if (a > b)
            {
                temp = a;
            }
            else // a < b
            {
                temp = b;
            }
            if (temp < c)
            {
                temp = c;
            }
            if (temp < d)
            {
                temp = d;
            }
            if (temp < e)
            {
                temp = e;
            }

            Console.WriteLine("The greatest number is: " + temp);
        }
    }

