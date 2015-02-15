namespace _02.CombinationsWithDuplicates
{
    using System;

    class CombinationsWithDuplicates
    {
        public static void Main()
        {
            int k = 2;
            int n = 3;
            int[] array = new int[k];
            GenerateLoops(0, array, n);
        }

        public static void GenerateLoops(int index, int[] array, int n)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                GenerateLoops(index + 1, array, n);
            }
        }
    }
}
