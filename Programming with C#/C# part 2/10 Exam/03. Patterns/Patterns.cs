namespace _03.Patterns
{
    using System;

    class Patterns
    {
        static void Main()
        {
            int[,] matrix = ReadInputMatrix();
            int bestSum = CalculateBestSum(matrix);

            if (bestSum != int.MinValue)
            {
                Console.WriteLine("YES " + bestSum);
            }
            else
            {
                bestSum = CalculateSumOnMainDiagonal(matrix);
                Console.WriteLine("NO " + bestSum);
            }
        }

        static int[,] ReadInputMatrix()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            string currentRow;
            string[] splittedCurrentRow;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentRow = Console.ReadLine();
                splittedCurrentRow = currentRow.Split(' ');

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = int.Parse(splittedCurrentRow[col]);
                }
            }

            return matrix;
        }

        static int CalculateBestSum(int[,] matrix)
        {
            int sum = int.MinValue;
            int bestSum = int.MinValue;
            int A, B, C, D, F, E, G;
            bool areConsecutive;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 4; col++)
                {
                    A = matrix[row, col];
                    B = matrix[row, col + 1];
                    C = matrix[row, col + 2];
                    D = matrix[row + 1, col + 2];
                    F = matrix[row + 2, col + 2];
                    E = matrix[row + 2, col + 3];
                    G = matrix[row + 2, col + 4];

                    areConsecutive = (A == B - 1) && (B == C - 1) && (C == D - 1) && (D == F - 1) && (F == E - 1) && (E == G - 1);

                    if (areConsecutive)
                    {
                        sum = A + B + C + D + F + E + G;
                    }
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                    }
                }
            }

            return bestSum;
        }

        static int CalculateSumOnMainDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0, col = 0; row < matrix.GetLength(0); row++, col++)
            {
                sum += matrix[row, col];
            }

            return sum;
        }
    }
}
