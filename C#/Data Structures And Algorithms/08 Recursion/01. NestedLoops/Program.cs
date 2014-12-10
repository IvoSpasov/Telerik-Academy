using System;
namespace _01.NestedLoops
{
    public class Program
    {
        public static void Main()
        {
            int n = 3;
            int[] array = new int[n];
            GenerateLoops(0, array);
        }

        public static void GenerateLoops(int index, int[] array)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[index] = i;
                GenerateLoops(index + 1, array);
            }
        }
    }
}
