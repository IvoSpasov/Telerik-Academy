using System;

class MatrixC
{
    static void Main()
    {
        Console.Write("Plese type in the size of the matrix: ");
        int mSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[mSize, mSize];
        int x = matrix.GetLength(1) - 1, y = 1, number = 1;

        while (x != -1)
        {
            for (int col = 0; col < matrix.GetLength(1) - x; col++)
            {
                for (int row = matrix.GetLength(0) - y; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number;
                    number++;
                    col++;
                }
                y++;
            }
            x--;
        }

        int a = 1, b = 1;

        while (a != matrix.GetLength(1))
        {
            for (int col = a; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - b; row++)
                {
                    matrix[row, col] = number;
                    number++;
                    col++;
                }
                b++;
            }
            a++;
        }

        // Print out
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
