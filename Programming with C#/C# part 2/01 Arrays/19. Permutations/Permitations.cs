// * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
// Example:	n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

// Sorry about the crazy logic. I simply modify the code of task 20. Variations to meet the needs of this taks. 
// All of the 3 programs -> 19, 20 and 21 are solved without using recursion.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please type in N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] myArray = new int[n];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = 1;
        }

        int index = n - 1;
        bool programExit = true;
        bool check = true;

        while (programExit)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)    // The difference is that I use those two additional "for" 
                {                                               //  loops to check if there are equal numbers in the array.
                    for (int k = j + 1; k < myArray.Length; k++)    // And if there are I simply don't print the whole array.
                    {
                        if (myArray[j] == myArray[k])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (!check)
                    {
                        break;
                    }
                    
                }
                if (check)
                {
                    string result = string.Join(", ", myArray);
                    Console.WriteLine(result);
                }
                check = true;
                myArray[index]++;
            }

            while (myArray[index] == n + 1)
            {
                myArray[index] = 1;
                index--;
                if (index < 0)
                {
                    programExit = false;
                    break;
                }
                myArray[index]++;
            }
            index = n - 1;
        }
        Console.WriteLine();
    }
}
