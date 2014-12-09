using System;

    class Sorting
    {
        static void Main()
        {
            int a = 1, b = 2, c = 3; // You can change the value of the variables here.

            if (a > b) // 1 level
            {
                if (a > c) // 2 level
                {
                    if (b > c) //3 level
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    else //c > b   3 level
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                        Console.WriteLine(b);
                    } 
                }
                else // c > a > b    2 level
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
            if (b > a) // 1 level
            {
                if (b > c) // 2 level
                {
                    if (a > c) // 3 level
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                    }
                    else // (c > a)   3 level
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(a);
                    }
                }
                else // c > b > a   2 level
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }
            // Yes, this is the hardest way to do it. And yes I should have done it an easier way.
        }
    }

