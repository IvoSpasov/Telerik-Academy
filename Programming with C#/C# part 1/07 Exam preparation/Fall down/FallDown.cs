using System;

class FallDown
{
    static void Main()
    {
        // Input

        int[] numbers = new int[8];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Solution

        for (int i = 1; i <= 7; i++)
        {
            for (int line = 7; line > 0; line--)
            {
                for (int bitPos = 0; bitPos < 8; bitPos++)
                {
                    if ((numbers[line] >> bitPos & 1) == 0 && (numbers[line - 1] >> bitPos & 1) == 1)
                    {
                        numbers[line] |= 1 << bitPos;
                        numbers[line - 1] ^= 1 << bitPos;
                    }
                }
            }
        }

        // Output

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

// score 100/100
