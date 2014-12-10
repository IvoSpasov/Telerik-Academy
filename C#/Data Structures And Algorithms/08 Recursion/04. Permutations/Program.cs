using System;
namespace _04.Permutations
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            int[] permutation = new int[n];

            //memoization in additional array
            bool[] usedNum = new bool[n + 1];

            ProcessNestedLoops(permutation, 0, usedNum);
        }

        private static void ProcessNestedLoops(int[] permutation, int arrIndex, bool[] usedNum)
        {
            if (arrIndex == permutation.Length)
            {
                Console.WriteLine(string.Join(", ", permutation));
                return;
            }

            for (int i = 1, len = permutation.Length; i <= len; i++)
            {
                if (!usedNum[i])
                {
                    permutation[arrIndex] = i;
                    usedNum[i] = true;
                    ProcessNestedLoops(permutation, arrIndex + 1, usedNum);
                    usedNum[i] = false;
                }

            }
        }
    }
}
