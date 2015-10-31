using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger firstNumber = 0, secondNumber = 1, sum;
            Console.WriteLine("This program prints the first 100 members of the sequence of Fibonacci.");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);


            for (int i = 0; i < 100; i++)
            {
                sum = firstNumber + secondNumber;
                
                firstNumber = secondNumber;
                secondNumber = sum;
                Console.WriteLine("{0}  {1}", i, sum);
            }

            // The code below is not required. It's just for fun and to show you why I use BigInteger.
            Console.WriteLine();
            Console.WriteLine(ulong.MaxValue + " - \"ulong\" max value");
            Console.WriteLine("\"ulong\" is not big enough to hold the last few values as you can see.");
        }
    }

