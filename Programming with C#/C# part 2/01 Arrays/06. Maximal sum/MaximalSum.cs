// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.

using System;
using System.Globalization;
using System.Threading;

class MaximalSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n, k;

        Console.Write("Please type in N: ");
        while (!(int.TryParse(Console.ReadLine(), out n) && n > 0))
        {
            Console.Write("Please type in N in the correct format (0 < N): ");
        }

        Console.Write("Please type in K: ");
        while (!(int.TryParse(Console.ReadLine(), out k) && k < n && k > 0))
        {
            Console.Write("Please type in K in the correct format (0 < K < N): ");
        }

        int[] myArray = new int[n];
        Console.WriteLine("Please fill in the array.");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("At index {0} -> ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArray);
        double sum = 0;

        Console.Write("The elements that have maximal sum are: ");
        for (int i = myArray.Length - k; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + ", ");
            sum += myArray[i];
        }

        Console.WriteLine("\b\b ");
        Console.WriteLine("Their sum is: " + sum);
    }
}