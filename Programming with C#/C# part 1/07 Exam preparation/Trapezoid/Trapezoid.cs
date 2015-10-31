using System;

class Program
{
    static void Main()
    {
        // Input
        int widthTop = int.Parse(Console.ReadLine());
        int widthBottom = 2 * widthTop;
        int height = widthTop + 1;
        int[,] matrix = new int[height, widthBottom];
        int row;
        int col;
        // Solution

        for (col = widthTop; col < widthBottom; col++)
        {
            matrix[0, col] = 1;
        }

        for (col = 0; col < widthBottom; col++)
        {
            matrix[height - 1, col] = 1;
        }

        row = 0;
        col = widthTop;

        while (row < height)
        {
            matrix[row, col] = 1;
            row++;
            col--;
        }

        row = 0;
        col = widthBottom - 1;
        while (row < height)
        {
            matrix[row, col] = 1;
            row++;
        }


        // Output
        for (row = 0; row < height; row++)
        {
            for (col = 0; col < widthBottom; col++)
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