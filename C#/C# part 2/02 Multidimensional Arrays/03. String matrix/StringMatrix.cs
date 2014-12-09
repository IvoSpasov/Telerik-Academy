// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor
// elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal 
// strings in the matrix.

using System;

class StringMatrix
{
    static void Main()
    {
        int counter = 1, bestCounter = 0, bestRow = 0, bestCol = 0, variant = 0;

        //string[,] matrix = {
        //                       {"a", "a", "z", "a", "b", "b"},
        //                       {"a", "b", "z", "z", "z", "c"}
        //                   };

        //string[,] matrix = {
        //                       {"s", "qq", "s"},
        //                       {"pp", "pp", "s"},
        //                       {"pp", "qq", "s"}
        //                   };

        //string[,] matrix = {
        //                       {"ha", "fifi", "ho", "hi"},
        //                       {"fo", "ha", "hi", "xx"},
        //                       {"xxx", "ho", "ha", "xx"},
        //                   };

        string[,] matrix = {
                               {"a", "b", "c", "d"},
                               {"e", "f", "hi", "g"},
                               {"h", "hi", "i", "j"},
                               {"hi", "k", "l", "m"}
                           };

        // Checking for similar elements in a row.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestRow = row;
                    bestCol = col + 1;
                    variant = 1;
                }
            }
            counter = 1;
        }

        // Checking for similar elements in a column.
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestRow = row + 1;
                    bestCol = col;
                    variant = 2;
                }
            }
            counter = 1;
        }

        // Checking for similar elements in a diagonal going from top left to bottom right.
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        bestRow = row + 1;
                        bestCol = col + 1;
                        variant = 3;
                    }
                }
                counter = 1;
            }
        }

        // Checking for similar elements in a diagonal going from top right to bottom left.
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = matrix.GetLength(1) - 1; j > 0; j--)
            {
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        bestRow = row + 1;
                        bestCol = col - 1;
                        variant = 4;
                    }
                }
                counter = 1;
            }
        }

        // Print out
        bool[,] colorCells = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        Console.Write("The longest sequence of equal elements is: ");
        switch (variant)
        {
            case 1:
                for (int i = bestCol; i > bestCol - bestCounter; i--)
                {
                    Console.Write(matrix[bestRow, i] + ", ");
                    colorCells[bestRow, i] = true;
                }
                Console.WriteLine("\b\b ");
                Console.WriteLine("They are located in row {0}.", bestRow + 1);

                break;
            case 2:
                for (int i = bestRow; i > bestRow - bestCounter; i--)
                {
                    Console.Write(matrix[i, bestCol] + ", ");
                    colorCells[i, bestCol] = true;
                }
                Console.WriteLine("\b\b ");
                Console.WriteLine("They are located in column {0}.", bestCol + 1);
                break;
            case 3:
                for (int row = bestRow, col = bestCol; row > bestRow - bestCounter; row--, col--)
                {
                    Console.Write(matrix[row, col] + ", ");
                    colorCells[row, col] = true;
                }
                Console.WriteLine("\b\b ");
                Console.WriteLine("They are located in a diagonal going from top left to bottom right.");
                break;
            case 4:
                for (int row = bestRow, col = bestCol; row > bestRow - bestCounter; row--, col++)
                {
                    Console.Write(matrix[row, col] + ", ");
                    colorCells[row, col] = true;
                }
                Console.WriteLine("\b\b ");
                Console.WriteLine("They are located in a diagonal going from top right to bottom left.");
                break;
        }

        // Make the elements in colour
        Console.WriteLine("Preview:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (colorCells[row, col] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0, 5}", matrix[row, col] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0, 5}", matrix[row, col] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine();
        }
    }
}