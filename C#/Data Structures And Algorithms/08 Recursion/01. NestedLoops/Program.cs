// Write a program to simulate n nested loops from 1 to n.

namespace _01.NestedLoops
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = 3;
            int[] currentRow = new int[n];
            GenerateLoops(0, currentRow);
        }

        public static void GenerateLoops(int index, int[] currentRow)
        {
            if (index == currentRow.Length)
            {
                Console.WriteLine(string.Join(", ", currentRow));
                return;
            }

            for (int i = 1; i <= currentRow.Length; i++)
            {
                currentRow[index] = i;
                GenerateLoops(index + 1, currentRow);
            }
        }
    }
}
