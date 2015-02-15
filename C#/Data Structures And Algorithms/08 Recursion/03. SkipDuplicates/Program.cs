namespace _03.SkipDuplicates
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int k = 2;
            int n = 4;
            int[] array = new int[k];
            GenerateLoops(0, 1, array, n);
        }

        public static void GenerateLoops(int index, int currentIndex, int[] array, int n)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int i = currentIndex; i <= n; i++)
            {
                array[index] = i;
                GenerateLoops(index + 1, i + 1, array, n);
            }
        }
    }
}
