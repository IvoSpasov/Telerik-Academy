// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class AlphabetArray
{
    static void Main()
    {
        char[] alphabet = new char[52];
        int letterCode = 97;

        for (int i = 0; i < 26; i++)
        {
            char letter = Convert.ToChar(letterCode);
            alphabet[i] = letter;
            letterCode++;
        }
        letterCode = 65;

        for (int i = 26; i < alphabet.Length; i++)
        {
            char letter = Convert.ToChar(letterCode);
            alphabet[i] = letter;
            letterCode++;
        }

        string result = string.Join(", ", alphabet);
        Console.WriteLine("This is how the alphabet looks like in the array: \n" + result);

        Console.Write("Enter your word: ");
        string word = Console.ReadLine();

        Console.WriteLine("The index of each letter is as follows: ");
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write("{0} -> {1}", word[i], j);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("\b\b ");
    }
}
