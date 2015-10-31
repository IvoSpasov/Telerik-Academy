using System;

class MatrixB
{
    static void Main()
    {
        Console.Write("Plese type in the size of the matrix: ");
        int mSize = int.Parse(Console.ReadLine());
        int number = 1;
        int[,] matrix = new int[mSize, mSize];

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
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

