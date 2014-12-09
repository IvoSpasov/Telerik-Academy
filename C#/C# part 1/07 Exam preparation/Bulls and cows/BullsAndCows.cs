using System;

class Program
{
    static void Main()
    {
        string sN = Console.ReadLine();
        int expectedBulls = int.Parse(Console.ReadLine());
        int expectedCows = int.Parse(Console.ReadLine());
        char usedSecretNum = '*';
        char usedGuessNum = '@';
        int counter = 0;

        for (int gN = 1111; gN <= 9999; gN++)
        {
            if (gN % 1000 == 0)
            {
                gN += 100;
            }
            if (gN % 100 == 0)
            {
                gN += 10;
            }
            if (gN % 10 == 0)
            {
                gN++;
            }

            char[] secretNumber = sN.ToCharArray();
            char[] guessNumber = gN.ToString().ToCharArray();
            int countBulls = 0;
            int countCows = 0;

            for (int i = 0; i < secretNumber.Length; i++) //counting bulls
            {
                if (secretNumber[i] == guessNumber[i])
                {
                    countBulls++;
                    secretNumber[i] = usedSecretNum;
                    guessNumber[i] = usedGuessNum;
                }
            }
            for (int i = 0; i < secretNumber.Length; i++) // counting cows
            {
                for (int j = 0; j < guessNumber.Length; j++)
                {
                    if (secretNumber[i] == guessNumber[j])
                    {
                        countCows++;
                        secretNumber[i] = usedSecretNum;
                        guessNumber[j] = usedGuessNum;
                    }
                }
            }

            if (countBulls == expectedBulls && countCows == expectedCows)
            {
                Console.Write(gN + " ");
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

// score 100/100