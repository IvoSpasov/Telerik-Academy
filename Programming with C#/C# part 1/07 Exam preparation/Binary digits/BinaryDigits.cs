using System;
using System.Collections.Generic;

class BinaryDigits
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        int totalNumbers = int.Parse(Console.ReadLine());
        List<long> results = new List<long>();

        for (int i = 0; i < totalNumbers; i++)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(inputNumber, 2);
            int counter = 0;

            for (int j = 0; j < binaryNumber.Length; j++)
            {
                long tempNumber = inputNumber & 1;

                if (B == 1 && tempNumber == 1)
                {
                    counter++;
                }
                else if (B == 0 && tempNumber == 0)
                {
                    counter++;
                }

                inputNumber >>= 1;
            }
            results.Add(counter);

        }
        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i]);
        }

    }
}

// Score 100/100
