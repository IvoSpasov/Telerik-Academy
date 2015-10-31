// Write a program that compares two char arrays lexicographically (letter by letter).

// I did this code wrong. The assignment is not fulfilled!

using System;

class CharArraysComparison
{
    static void Main()
    {
        Console.WriteLine("This program compares two char arrays.");
        Console.Write("Please write the first char array: ");
        string firstString = Console.ReadLine();
        Console.Write("Please write the second char array: ");
        string secondString = Console.ReadLine();

        if (firstString.Length == secondString.Length)
        {
            char[] firstArray = new char[firstString.Length];
            char[] secondArray = new char[secondString.Length];
            firstArray = firstString.ToCharArray();
            secondArray = secondString.ToCharArray();
            bool check = true;

            for (int index = 0; index < firstArray.Length; index++)
            {
                check = firstArray[index] == secondArray[index];

                if (!check)
                {
                    Console.WriteLine("The char arrays are NOT equal.");
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("The char arrays are equal.");
            }
        }

        else
        {
            Console.WriteLine("The arrays have different lengh so they are different.");
        }

    }
}

