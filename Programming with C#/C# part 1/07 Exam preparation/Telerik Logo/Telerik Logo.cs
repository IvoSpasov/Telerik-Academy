using System;

class TelerikLogo
{
    static void Main()
    {
        // Input
        int X = int.Parse(Console.ReadLine());
        int Y = X;
        int Z = (X / 2) + 1;
        int width = (2 * Z) + (2 * Y) - 3;
        int height = width;
        int[,] matrix = new int[height, width];

        // Solution 
        int row = (X / 2) + 1;
        int col = -1;

        while (row > 0)
        {
            row--;
            col++;
            matrix[row, col] = 1;
        }
        while (col < width - Z)
        {
            row++;
            col++;
            matrix[row, col] = 1;
        }
        while (row < height - 1)
        {
            row++;
            col--;
            matrix[row, col] = 1;
        }
        while (col > Z - 1)
        {
            row--;
            col--;
            matrix[row, col] = 1;
        }
        while (row > 0)
        {
            row--;
            col++;
            matrix[row, col] = 1;
        }
        while (col < width - 1)
        {
            row++;
            col++;
            matrix[row, col] = 1;
        }

        // Output
        for (row = 0; row < height; row++)
        {
            for (col = 0; col < width; col++)
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