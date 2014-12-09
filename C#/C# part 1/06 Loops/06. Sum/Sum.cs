using System;


    class Sum
    {
        static void Main()
        {
            int n, x;
            double sum = 1, nFactorial = 1, xPow;
            
            Console.WriteLine("This program calculates the sum S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N.");
            Console.Write("Please type in \"N\" (N > 0): ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n > 0)))
            {
                Console.Write("Please type in \"N\" (N > 0) in the correct format: ");
            }

            Console.Write("Please type in \"X\": ");
            while (!((int.TryParse(Console.ReadLine(), out x))))
            {
                Console.Write("Please type in \"X\" in the correct format: ");
            }

            for (int i = 1; i <= n; i++)
			{
                nFactorial *= i;
                xPow = (int)Math.Pow(x, i);
			    sum += nFactorial/xPow;
			}
            Console.WriteLine("The result is: " + sum);
        }
    }

