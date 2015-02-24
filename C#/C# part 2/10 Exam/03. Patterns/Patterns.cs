using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Patterns
{
    class Patterns
    {
        static void Main()
        {
            int[,] matrix = ReadInputMatrix();
            int sum = 0;
            int bestSum = 0;
            int A, B, C, D, F, E, G;

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

                    bool areConsecutive = (A == B - 1) && (B == C - 1) && (C == D - 1) && (D == F - 1) && (F == E - 1) && (E == G - 1);

                    if (areConsecutive)
                    {
                        sum = A + B + C + D + F + E + G;
                    }
                }

                if (bestSum < sum)
                {
                    bestSum = sum;
                }
            }

            Console.WriteLine("YES " + bestSum);
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
    }
}
