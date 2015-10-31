// You are given an array of strings. Write a method that sorts the array by the length of its elements 
// (the number of characters composing them).

using System;

class ArrayOfStrings
{
    static void Main()
    {
        string[] myArray = { "abcd", "abcdefgh", "ab", "abc", "abcdef", "a", "abcde" };
        //string[] myArray = { "a", "aaaa", "aa", "aaa"};
        int tempIndex = 0;
        bool check = false;

        for (int i = 0; i < myArray.Length - 1; i++)
        {
            string temp = myArray[i];
            int lenght = temp.Length;
            string tempValue = "";

            for (int j = i + 1; j < myArray.Length; j++)
            {
                string temp2 = myArray[j];
                int lenght2 = temp2.Length;

                if (lenght > lenght2)
                {
                    lenght = lenght2;
                    tempIndex = j;
                    tempValue = myArray[j];
                    check = true;
                }
            }

            if (check)
            {
                myArray[tempIndex] = myArray[i];
                myArray[i] = tempValue;
            }
            check = false;

        }

        // Print out
        string result = string.Join(", ", myArray);
        Console.WriteLine(result);
    }
}

