using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n;

            Console.WriteLine("This program prints the numbers form 1 to N.");
            Console.Write("Please type in an integer number (N): ");
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.Write("Please type in an integer number (N) in the correct format: ");
            }

            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i >= n; i--)
                {
                    Console.WriteLine("{0,2}", i);
                }
            }
        }
    }

