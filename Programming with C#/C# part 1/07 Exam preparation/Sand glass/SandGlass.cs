using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int row, col;
        int center = N/2;

        //Solution

        int a = 0, b = N;

        for (row = 0; row < center; row++)
        {
            for (col = a; col < b; col++)
            {
                matrix[row, col] = 1;
            }
            a++;
            b--;
        }

        a = center; 
        b = center;

        for (row = center; row < N; row++)
        {
            for (col = a; col <= b; col++)
            {
                matrix[row, col] = 1;
            }
            a--;
            b++;
        }



        // Output
        for (row = 0; row < N; row++)
        {
            for (col = 0; col < N; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }

    }
}

// Score 100/100