using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            int n;
            BigInteger nominator = 1, denominator = 1, result;

            Console.WriteLine("This program calculates the N-th Catalan number by given N.");
            Console.Write("Please type in \"N\" (N >= 0): ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n >= 0)))
            {
                Console.Write("Please type in \"N\" (N >= 0): in the correct format: ");
            }
            
            for (int i = n+2; i <= n*2; i++)
			{
                nominator *= i;
			}
            for (int i = 1; i <= n; i++)
            {
                denominator *= i;
            }

            result = nominator / denominator / 2;
            Console.WriteLine("The result is: " + result);
        }
    }

