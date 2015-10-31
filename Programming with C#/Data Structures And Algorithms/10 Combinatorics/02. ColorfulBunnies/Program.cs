namespace _02.ColorfulBunnies
{
    using System;

    class Program
    {
        static void Main()
        {
            int numberOfAskedBunnies = int.Parse(Console.ReadLine());
            int[] equalBunnyAnswersCount = new int[1000002];

            for (int i = 0; i < numberOfAskedBunnies; i++)
            {
                equalBunnyAnswersCount[int.Parse(Console.ReadLine()) + 1] += 1;
            }

            long bunniesCount = 0;

            for (int i = 0; i < equalBunnyAnswersCount.Length; i++)
            {
                if (equalBunnyAnswersCount[i] == 0)
                {
                    continue;
                }
                else
                {
                    bunniesCount += (int)Math.Ceiling((double)equalBunnyAnswersCount[i] / i) * i;
                }
            }

            Console.WriteLine(bunniesCount);
        }
    }
}
