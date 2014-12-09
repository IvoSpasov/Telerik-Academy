using System;
using System.Threading;
using System.Globalization; // for floating point numbers

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());

        decimal A, B, C, D;

        A = (N * N) + (1 / (M * P)) + 1337;
        B = N - (128.523123123m * P);
        C = M % 180;
        D = Convert.ToDecimal(Math.Sin((int)C));

        decimal result = (A / B) + D;
        Console.WriteLine("{0:F6}", result);
    }
}

// Score 100/100