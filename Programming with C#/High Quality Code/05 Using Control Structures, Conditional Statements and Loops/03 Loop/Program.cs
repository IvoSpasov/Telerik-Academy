// Refactor the following loop:

namespace _03_Loop
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            int expectedValue = 1000;
            bool isValueFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    isValueFound = true;
                }

                Console.WriteLine(array[i]);
            }

            // More code here
            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}