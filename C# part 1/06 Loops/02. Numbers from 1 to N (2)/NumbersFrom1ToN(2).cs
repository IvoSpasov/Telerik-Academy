using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n;
            bool parseSuccess = true;

            Console.WriteLine("This program prints all the numbers form 1 to N, that are NOT divisible by\n" +
                "3 and 7 at the same time.");
            Console.Write("Please type in an integer number (N): ");
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.Write("Please type in an integer number (N) in the correct format: ");
            }

            if (n >= 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (!((i % 3 == 0) && (i % 7 == 0))) // or (i % 21 == 0) which is probably faster.
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i >= n; i--)
                {
                    if (!((i % 3 == 0) && (i % 7 == 0)))
                    {
                        Console.WriteLine(i);
                    }
                }
            }       
            
        }
    }

