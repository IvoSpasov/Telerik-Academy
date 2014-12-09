// This program is not 100% fixed !!

using System;

class LexicographicalComparison1
{
    static string LexicographicalComparison(string firstString, string secondString)
    {
        char[] firstArray = new char[firstString.Length];
        char[] secondArray = new char[secondString.Length];
        firstArray = firstString.ToCharArray();
        secondArray = secondString.ToCharArray();

        int lenght = firstArray.Length;
        if (firstArray.Length > secondArray.Length)
        {
            lenght = secondArray.Length;
        }

        // In case the first letter is small one -> make it upper case 
        if (lenght != 0)
        {
            firstArray[0] = char.ToUpper(firstArray[0]);
            secondArray[0] = char.ToUpper(secondArray[0]);
        }

        for (int index = 0; index < lenght; index++)
        {
            if (firstArray[index] == secondArray[index])
            {
                continue;
            }
            else if (firstArray[index] < secondArray[index])
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        // In case one or two of the strings is empty || (or) the strings are equal up to the last letter of the shorter one (then return the shorter one).

        if ((firstArray.Length != 0 && secondArray.Length == 0) || firstArray.Length < secondArray.Length)
        {
            return firstString;
        }
        else if ((secondString.Length != 0 && firstArray.Length == 0) || firstArray.Length > secondArray.Length)
        {
            return secondString;
        }
        // in case both strings are qual but not empty
        else if (firstArray.Length != 0 && firstString == secondString)
        {
            return firstString;
        }
        else
        {
            return "Error: Both strings are empty.";
        }
    }

    static void Main()
    {
        Console.WriteLine("This program compares two string (lexicographically).");
        Console.Write("Please write the first string: ");
        string firstString = Console.ReadLine();
        Console.Write("Please write the second string: ");
        string secondString = Console.ReadLine();
        Console.WriteLine("The fist is: " + LexicographicalComparison(firstString, secondString));
    }
}
