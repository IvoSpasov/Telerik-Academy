// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Example:	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class Variations
{
    static void Main()
    {
        Console.Write("Please type in N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please type in K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] myArray = new int[k];

        for (int i = 0; i < myArray.Length; i++) // <- Simply creating an array full of "1".
        {
            myArray[i] = 1;
        }

        int index = k - 1;
        bool programExit = true;

        while (programExit)
        {
            for (int i = 0; i < n; i++) // <- Printing the result
            {
                string result = string.Join(", ", myArray);
                Console.WriteLine(result);
                myArray[index]++;
            }

            while (myArray[index] == n + 1) // <- Generating the numbers and different cases
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
            index = k - 1;
        }
        Console.WriteLine();
    }
}
