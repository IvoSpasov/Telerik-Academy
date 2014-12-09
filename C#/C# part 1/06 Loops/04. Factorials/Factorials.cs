using System;
using System.Numerics;

    class Factorials
    {
        static void Main()
        {
            int n, k;
            BigInteger division = 1;

            Console.WriteLine("This program calculates N!/K! for given \"N\" and \"K\".");
            Console.Write("Please type in K! (K > 1): ");
            while (!((int.TryParse(Console.ReadLine(), out k)) && (k > 1)))
            {
                Console.Write("Please type in K! (K > 1) in the correct format: ");
            }

            Console.Write("Please type in N! (N > K): ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n > k)))
            {
                Console.Write("Please type in N! (N > K) in the correct format: ");
            }
            
            for (int i = k + 1; i <= n; i++)
            {
                division *= i;
            }

            Console.WriteLine("The result is: " + division);
        }
    }

