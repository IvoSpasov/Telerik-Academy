//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ArrayComparison
{
    static void Main()
    {
        Console.WriteLine("This program compares two integer arrays.");
        Console.Write("Please type in the lenght of the first array: ");
        int lenghtFirst = int.Parse(Console.ReadLine());
        Console.Write("Please type in the lenght of the second array: ");
        int lenghtSecond = int.Parse(Console.ReadLine());

        if (lenghtFirst == lenghtSecond) // if the lenght is different, there is no need to continue and fill in the arrays.
        {
            int[] arrayOne = new int[lenghtFirst];
            int[] arrayTwo = new int[lenghtSecond];

            Console.WriteLine("Please fill in the first array.");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("At index {0} = ", i);
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please fill in the second array.");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write("Index {0} = ", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            // Up to here we create and fill in the two arrays.
            // Now let's compare them.

            bool check = false;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                check = arrayOne[i] == arrayTwo[i];
                if (!check)
                {
                    Console.WriteLine("The arrays are NOT equal.");
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("The arrays are equal.");
            }

        }

        else
        {
            Console.WriteLine("The arrays have different lengh so they are different.");
        }

    }
}

