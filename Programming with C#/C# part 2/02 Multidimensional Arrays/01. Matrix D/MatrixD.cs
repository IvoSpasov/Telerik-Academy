using System;

class MatrixD
{
    static void Main()
    {
        int mSize;
        Console.WriteLine("This program reads a positive integer number and outputs a spiral matrix.");
        Console.Write("Please type in \"N\": ");
        while (!(int.TryParse(Console.ReadLine(), out mSize) && mSize >= 0))
        {
            Console.Write("Please type in \"N\" in the correct format: ");
        }

        int[,] matrix = new int[mSize, mSize];
        int number = 1;
        int x = 0, y = 0; // Variables used for changing width and height of the rows and columns.


        while (number != (mSize * mSize) + 1)
        {
            //down
            for (int row = y; row < matrix.GetLength(0) - y; row++)
            {
                int col = x; 
                matrix[row, col] = number;
                number++;
            }
            
            //left
            for (int col = x + 1; col < matrix.GetLength(1) - x; col++)
            {
                int row = matrix.GetLength(0) - 1 - y;
                matrix[row, col] = number;
                number++;
            }

            //up                
            for (int row = matrix.GetLength(0) - 2 - y; row >= y; row--)
            {
                int col = matrix.GetLength(1) - 1 - x;
                matrix[row, col] = number;
                number++;
            }
            
            //right
            for (int col = matrix.GetLength(1) - 2 - x; col >= x + 1; col--)
            {
                int row = y;
                matrix[row, col] = number;
                number++;
            }

            y++;
            x++;
        }

        // Print out
        Console.WriteLine("And here is your marix:");
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

