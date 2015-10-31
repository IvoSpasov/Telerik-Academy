namespace _01.BinaryPasswords
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int numberOfAsterisks = CountAsterisks(input);
            int n = 2;
            long variationWithRepetition = (long)Math.Pow(n, numberOfAsterisks);
            Console.WriteLine(variationWithRepetition);
        }

        static int CountAsterisks(string input)
        {
            int counter = 0;

            foreach (var symbol in input)
            {
                if (symbol == '*')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
