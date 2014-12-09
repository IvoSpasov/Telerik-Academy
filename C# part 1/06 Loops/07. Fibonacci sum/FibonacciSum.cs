using System;
using System.Numerics;

    class FibonacciSum
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = 0, secondNumber = 1, sum, sumAll = 1;
            int n;

            Console.WriteLine("This program calculates the sum of the first \"N\" members of the sequence of\nFibonacci.");
            Console.Write("Please type in \"N\" (N > 1): ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n > 1)))
            {
              Console.Write("Please type in \"N\" (N > 1) in the correct format: ");  
            }

            for (int i = 2; i < n; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
                sumAll += sum;
            }
            Console.WriteLine("The result is: " + sumAll);
        }
    }

