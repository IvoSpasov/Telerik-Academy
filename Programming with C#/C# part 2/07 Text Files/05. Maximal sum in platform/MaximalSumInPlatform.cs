// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area 
// of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
// Each of the next N lines contains N numbers separated by space. The output should be a single number in a separate
// text file. Example:
//4
//2 3 3 4
//0 2 3 4	 ----->17
//3 7 1 2
//4 3 3 2


// I decided to print not only the sum in the output file, but the platform itslef as well !

using System;
using System.Text;
using System.IO;

class MaximalSumInPlatform
{
    static void Main()
    {
        int platformSize = 2; // here you can change the size of the platform.

        try
        {
            StreamReader reader = new StreamReader(@"..\..\Matrix (input).txt");
            StreamWriter writer = new StreamWriter(@"..\..\Result (output).txt");

            long sum = 0, bestSum = long.MinValue;
            int bestRow = 0, bestCol = 0;

            int size = int.Parse(reader.ReadLine());
            int[,] matrix = new int[size, size];

            // Read from file and fill in a matrix.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = reader.ReadLine();
                string[] numbersAsStrings = currentRow.Split(' ');

                for (int col = 0; col < matrix.GetLength(1) && col < numbersAsStrings.Length; col++)
                {
                    matrix[row, col] = int.Parse(numbersAsStrings[col]);
                }
            }
            // Close the object for reading and continue to work with the matrix.
            reader.Close();

            // Calculate the maximal sum in the platform.
            for (int row = 0; row < matrix.GetLength(0) - (platformSize - 1); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - (platformSize - 1); col++)
                {
                    for (int rowPlat = row; rowPlat < row + platformSize; rowPlat++)
                    {
                        for (int colPlat = col; colPlat < col + platformSize; colPlat++)
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

            // Write the result in the output file.
            writer.WriteLine("The maximal platform is:");
            for (int row = bestRow; row < bestRow + platformSize; row++)
            {
                for (int col = bestCol; col < bestCol + platformSize; col++)
                {
                    writer.Write("{0,4}", matrix[row, col] + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine("The best sum is: " + bestSum);

            // Close the object for writing.
            writer.Close();

            Console.WriteLine("Calculation of the maximal platfrom was successful.");

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}