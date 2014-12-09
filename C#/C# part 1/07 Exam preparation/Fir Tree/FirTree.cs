using System;

class FirTree
{
    static void Main()
    {
        // Input
        int h = int.Parse(Console.ReadLine());
        int w = (h * 2) - 3;
        int[,] matrix = new int[h, w];
        int row, col;
        int a = w/2, b = w/2;
        // Solution

        for (row = 0; row < h-1; row++)
        {
            for (col = a; col <= b; col++)
            {
                matrix[row, col] = 1;
            }
            a--;
            b++;
        }
        matrix[h - 1, w / 2] = 1;


        // Output
        for (row = 0; row < h; row++)
        {
            for (col = 0; col < w; col++)
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

