namespace _05.StringVariations
{
    using System;

    class StringVariations
    {
        static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());

            string[] set = new string[n + 1];//{" ", "hi", "a", "b"};
            string[] variation = new string[k];

            Console.WriteLine("now enter {0} strings", n);
            for (int i = 1; i < n + 1; i++)
            {
                set[i] = Console.ReadLine();
            }

            ProcessVariations(set, variation, 0);
        }

        private static void ProcessVariations(string[] set, string[] variation, int arrIndex)
        {
            if (arrIndex == variation.Length)
            {
                Console.WriteLine(string.Join(", ", variation));
                return;
            }

            for (int i = 1, len = set.Length; i < len; i++)
            {
                variation[arrIndex] = set[i];
                ProcessVariations(set, variation, arrIndex + 1);
            }
        }
    }
}
