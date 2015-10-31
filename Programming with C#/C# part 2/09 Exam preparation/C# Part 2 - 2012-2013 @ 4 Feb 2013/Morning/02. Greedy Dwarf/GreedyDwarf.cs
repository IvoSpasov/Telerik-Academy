using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Greedy_Dwarf
{
    class GreedyDwarf
    {
        static int[] RowToArray(string row)
        {
            string[] separators = { " ", "," };
            string[] rowStrArray = row.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] rowArray = new int[rowStrArray.Length];

            for (int i = 0; i < rowStrArray.Length; i++)
            {
                rowArray[i] = int.Parse(rowStrArray[i]);
            }

            return rowArray;
        }

        static void Main()
        {
            string valley = Console.ReadLine();
            int[] valleyArray = RowToArray(valley);
            int[] valleyArrayCopy = new int[valleyArray.Length];
            Array.Copy(valleyArray, valleyArrayCopy, valleyArray.Length);
            int M = int.Parse(Console.ReadLine());
            int[][] patternMatrix = new int[M][];

            for (int i = 0; i < patternMatrix.GetLength(0); i++)
            {
                string pattern = Console.ReadLine();
                patternMatrix[i] = RowToArray(pattern);
            }

            int collected = 0;
            int bestCollected = int.MinValue;
            int index = 0;

            for (int i = 0; i < patternMatrix.GetLength(0); i++)
            {
                Array.Copy(valleyArrayCopy, valleyArray, valleyArrayCopy.Length);

                for (int j = 0; ; j++)
                {
                    if (j == patternMatrix[i].Length)
                    {
                        j = 0;
                    }

                    collected += valleyArray[index];
                    valleyArray[index] = 2000;

                    index += patternMatrix[i][j];

                    if (valleyArray.Length <= index || index < 0)
                    {
                        if (collected > bestCollected)
                        {
                            bestCollected = collected;
                        }

                        index = 0;
                        collected = 0;
                        break;
                    }

                    if (valleyArray[index] == 2000)
                    {
                        if (collected > bestCollected)
                        {
                            bestCollected = collected;
                        }

                        index = 0;
                        collected = 0;
                        break;
                    }
                }
            }

            Console.WriteLine(bestCollected);
        }
    }
}
