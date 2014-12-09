using System;
using System.Numerics;

    class Factorials2
    {
        static void Main()
        {
            int n, k;
            BigInteger nFactorial = 1, kResFactorial = 1, result = 1; 
            
            Console.WriteLine("This program calculates N!*K! / (K-N)! for given N and K (1<N<K).");
            Console.Write("Please type in N! (N > 1): ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n > 1)))
            {
                Console.Write("Please type in N! (N > 1) in the correct format: ");
            }

            Console.Write("Please type in K! (K > N): ");
            while (!((int.TryParse(Console.ReadLine(), out k)) && (k > n)))
            {
                Console.Write("Please type in K! (K > N) in the correct format: ");
            }

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            for (int i = k - n + 1; i <= k; i++)
            {
                kResFactorial *= i;
            }

            result = nFactorial * kResFactorial;
            Console.WriteLine("The result is: " + result);

        }
    }

