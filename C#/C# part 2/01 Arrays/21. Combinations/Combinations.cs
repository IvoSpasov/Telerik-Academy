// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements 
// from the set [1..N]. Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4},
// {3, 5}, {4, 5}

// In this program I also use the code and logic of task 20. Variations, but it's modified more or less to meet
// the needs of this program.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please type in N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please type in K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] myArray = new int[k];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }

        int index = k - 1;
        bool programExit = true;

        while (programExit)
        {
            while (myArray[index] <= n)
            {
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] == myArray[i + 1])
                    {
                        myArray[i + 1]++;
                        break;
                    }
                }
                if (myArray[index] <= n)
                {
                    string result = string.Join(", ", myArray);
                    Console.WriteLine(result);
                    myArray[index]++;
                }
            }

            while (myArray[index] >= n + 1)
            {
                myArray[index] = 1;
                index--;
                if (index < 0)
                {
                    programExit = false;
                    break;
                }

                myArray[index]++;
                index++;

                if (myArray[index - 1] > myArray[index])
                {
                    myArray[index] = myArray[index - 1];
                }

                index--;
            }
            index = k - 1;
        }
        Console.WriteLine();
    }
}
