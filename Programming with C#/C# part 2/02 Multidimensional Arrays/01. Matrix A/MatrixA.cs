using System;

class MatrixA
{
    static void Main()
    {
        Console.Write("Plese type in the size of the matrix: ");
        int mSize = int.Parse(Console.ReadLine());
        int number = 1;
        int[,] matrix = new int[mSize, mSize];

        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, column] = number;
                number++;
            }
        }

        // Print out
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write("{0,4}", matrix[row, column] + " ");
            }
            Console.WriteLine();
        }
    }
}