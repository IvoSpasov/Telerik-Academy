using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int firstBit = 100;
        int lastBit = 0;
        long tempNumber = 0;

        List<long> results = new List<long>();

        for (; ; )
        {
            long inputNumber = long.Parse(Console.ReadLine());
            if (inputNumber == -1)
            {
                break;
            }

            firstBit = 100;

            for (int bitPos = 0; bitPos <= 40; bitPos++)
            {
                tempNumber = inputNumber >> bitPos;
                tempNumber &= 1;
                if (tempNumber == 1)
                {
                    lastBit = bitPos;

                    if (lastBit - firstBit <= 1)
                    {
                        firstBit = lastBit;
                    }
                }
            }

            for (int bitPos = lastBit; bitPos >= 0; bitPos--)
            {
                tempNumber = inputNumber >> bitPos;
                tempNumber &= 1;
                if (tempNumber == 1)
                {
                    lastBit = bitPos;
                }
                else if (tempNumber == 0)
                {
                    break;
                }
            }

            long outputNumber = 0;

            if (firstBit == lastBit)
            {
                results.Add(outputNumber);
            }
            else
            {
                for (int i = firstBit + 1; i < lastBit; i++)
                {
                    tempNumber = 1 << i;
                    outputNumber |= tempNumber;
                }
                results.Add(outputNumber);
            }

        }

        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i]);
        }
    }
}

// score 100/100