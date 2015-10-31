//Write a program for generating and printing all subsets of k strings from given set of strings.
//Example: s = {test, rock, fun}, k=2
//(test rock),  (test fun),  (rock fun) 

namespace _06.PrintSubsetOfStrings
{
    using System;   

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
        

        // Second variant

        //public static void Main()
        //{
        //    string[] words = new string[] { "test", "rock", "fun" };
        //    int k = 2;
        //    int[] currentRowIndexes = new int[k];

        //    GenerateVariations(0, currentRowIndexes, words);
        //}

        //public static void GenerateVariations(int index, int[] currentRowIndexes, string[] words)
        //{
        //    if (index == currentRowIndexes.Length)
        //    {
        //        PrintRow(words, currentRowIndexes);
        //        return;
        //    }

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        currentRowIndexes[index] = i;

        //        if (index != 0 && currentRowIndexes[index - 1] >= currentRowIndexes[index])
        //        {
        //            continue;
        //        }

        //        GenerateVariations(index + 1, currentRowIndexes, words);
        //    }
        //}

        //public static void PrintRow(string[] words, int[] currentRowIndexes)
        //{
        //    Console.Write("(");
        //    for (int i = 0; i < currentRowIndexes.Length; i++)
        //    {
        //        Console.Write(words[currentRowIndexes[i]]);
        //        if (i < currentRowIndexes.Length - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //    }

        //    Console.Write(")");
        //    Console.WriteLine();
        //}
    }
}
