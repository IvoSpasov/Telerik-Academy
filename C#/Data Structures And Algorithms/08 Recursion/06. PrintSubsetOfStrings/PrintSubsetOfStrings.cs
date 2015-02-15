namespace _06.PrintSubsetOfStrings
{
    using System;

    //Write a program for generating and printing all subsets of k strings from given set of strings.
    //Example: s = {test, rock, fun}, k=2
    //(test rock),  (test fun),  (rock fun)    

    class PrintSubsetOfStrings
    {
        static void Main()
        {
            int k = 2;
            string[] words = new string[] { "test", "rock", "fun" };
            string[] wordsVariation = new string[k];

            GenerateVariations(words, wordsVariation, 0, 0);
        }

        private static void GenerateVariations(string[] words, string[] wordsVariation, int wordsVariationIndex, int wordsStartIndex)
        {
            if (wordsVariationIndex == wordsVariation.Length)
            {
                PrintRow(wordsVariation);
                return;
            }

            for (int i = wordsStartIndex; i < words.Length; i++)
            {
                wordsVariation[wordsVariationIndex] = words[i];

                GenerateVariations(words, wordsVariation, wordsVariationIndex + 1, i + 1);
            }
        }

        private static void PrintRow(string[] wordsVariation)
        {
            Console.WriteLine("(" + String.Join(" ", wordsVariation) + ")");
        }
    }
}
