using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        if (num < 0)
        {
            num *= -1;
        }
        string n = Convert.ToString(num);
        int specialSum = 0;
        int digitPos = 1;

        int[] numArray = new int[n.Length];

        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = Convert.ToInt32(new string(n[i], 1));
        }

        for (int i = numArray.Length - 1; i >= 0; i--)
        {
            if (digitPos % 2 == 0) // even postition of the number
            {
                specialSum += numArray[i] * numArray[i] * digitPos;
            }
            else // odd position of the number
            {
                specialSum += numArray[i] * digitPos * digitPos;
            }
            digitPos++;
        }

        Console.WriteLine(specialSum);

        string specialN = specialSum.ToString();
        int lastDigit = Convert.ToInt32(new string(specialN[specialN.Length - 1], 1));


        if (lastDigit == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            int R = (specialSum % 26) + 1;
            int counter = 0;
            int alphaSequence = 64 + R;

            while (counter < lastDigit)
            {
                Console.Write((char)alphaSequence);
                alphaSequence++;
                counter++;
                if (alphaSequence == 91)
                {
                    alphaSequence = 65;
                }
            }
        }
        Console.WriteLine();
    }
}

//Score 100/100