// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal 
// sum of its elements.

using System;

class MaximalSumInPlatform
{
    static void Main()
    {
        Console.Write("Please type in the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please type in the nubmer of columns: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        long sum = 0, bestSum = long.MinValue;
        int bestRow = 0, bestCol = 0;

        Console.WriteLine("Please enter the elements of the matrix:");

        // You can use this type of code to raed the matrix.
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("Index[{0}, {1}] = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        // Or you can use this.
        string[] separators = { " ", ", ", "\t" };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string currentRow = Console.ReadLine();
            string[] numbersAsStrings = currentRow.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < matrix.GetLength(1) && col < numbersAsStrings.Length; col++)
            {
                matrix[row, col] = int.Parse(numbersAsStrings[col]);
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                for (int rowPlat = row; rowPlat < row + 3; rowPlat++)
                {
                    for (int colPlat = col; colPlat < col + 3; colPlat++)
                    {
                        sum += matrix[rowPlat, colPlat];
                    }
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
                sum = 0;
            }
        }

        // Print out

        Console.WriteLine("The maximal platform is:");
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0,4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The best sum is: " + bestSum);
    }
}

