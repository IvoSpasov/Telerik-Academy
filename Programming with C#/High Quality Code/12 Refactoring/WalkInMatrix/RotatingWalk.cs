namespace WalkInMatrix
{
    using System;

    public class RotatingWalk
    {
        public static void Main()
        {
            int n = ReadInput();
            int[,] matrix = CreateRotatingWalkMatrix(n);
            PrintMatrix(matrix);
        }

        public static int[,] CreateRotatingWalkMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int number = 1;
            int row = 0;
            int col = 0;

            FillMatrix(matrix, ref number, ref row, ref col);

            FindEmptyCell(matrix, out row, out col);
            number++;

            if (row != 0 && col != 0)
            {
                FillMatrix(matrix, ref number, ref row, ref col);
            }

            return matrix;
        }

        private static void FillMatrix(int[,] matrix, ref int number, ref int row, ref int col)
        {
            int dirY = 1;
            int dirX = 1;
            int n = matrix.GetLength(0);

            while (true)
            {
                matrix[row, col] = number;

                if (IsMatrixFull(matrix, row, col))
                {
                    break;
                }

                while ((row + dirY >= n || row + dirY < 0 || col + dirX >= n || col + dirX < 0 || matrix[row + dirY, col + dirX] != 0))
                {
                    ChangeDirection(ref dirY, ref dirX);
                }

                row += dirY;
                col += dirX;
                number++;
            }
        }

        private static bool IsMatrixFull(int[,] matrix, int row, int col)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (row + directionsX[i] >= matrix.GetLength(0) || row + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }

                if (col + directionsY[i] >= matrix.GetLength(0) || col + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + directionsX[i], col + directionsY[i]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirectionPosition = 0;
            for (int i = 0; i < directionsX.Length; i++)
            {
                if (directionsX[i] == dx && directionsY[i] == dy)
                {
                    currentDirectionPosition = i;
                    break;
                }
            }

            if (currentDirectionPosition == 7)
            {
                dx = directionsX[0];
                dy = directionsY[0];
            }
            else
            {
                dx = directionsX[currentDirectionPosition + 1];
                dy = directionsY[currentDirectionPosition + 1];
            }
        }

        private static void FindEmptyCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private static int ReadInput()
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();
            int n;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.Write("Please enter positive number between 1 and 100: ");
                input = Console.ReadLine();
            }

            return n;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
