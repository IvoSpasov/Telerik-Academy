// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class PrimeNumbers
{
    static void Main()
    {
        // First variant...................................................

        int[] primes = new int[10000001];

        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = i;
        }

        for (int num = 0; num < primes.Length; num++)
        {
            if ((((num == 1) || (num % 2 == 0) || (num % 3 == 0) || (num % 5 == 0) || (num % 7 == 0) || (num % 9 == 0))
                ^ (num == 2 || num == 3 || num == 5 || num == 7)))
            {
                primes[num] = 0;
            }
        }

        // Print out
        for (int i = 0; i < 1000; i++) // Printing the prime numbers up to 10 000 000 is probaly not the best idea.
        {
            if (primes[i] != 0)
            {
                Console.Write(primes[i] + ", ");
            }

        }
        Console.WriteLine("\b\b ");


        // Second variant..................................................................

        //for (int i = 0; i < primes.Length; i++)
        //{
        //    primes[i] = i;
        //}
        //primes[1] = 0; 
        //for (int i = 0; i < primes.Length; i += 2)
        //{
        //    if (primes[i] != 2)
        //    {
        //        primes[i] = 0;
        //    }
        //}
        //for (int i = 0; i < primes.Length; i += 3)
        //{
        //    if (primes[i] != 3)
        //    {
        //        primes[i] = 0;
        //    } 
        //}
        //for (int i = 0; i < primes.Length; i += 5)
        //{
        //    if (primes[i] != 5)
        //    {
        //        primes[i] = 0;
        //    } 
        //}
        //for (int i = 0; i < primes.Length; i += 7)
        //{
        //    if (primes[i] != 7)
        //    {
        //        primes[i] = 0;
        //    } 
        //}

        //for (int i = 0; i < 1000; i++)
        //{
        //    if (primes[i] != 0)
        //    {
        //        Console.Write(primes[i] + ", ");
        //    }

        //}
        //Console.WriteLine("\b\b ");
    }   
}

