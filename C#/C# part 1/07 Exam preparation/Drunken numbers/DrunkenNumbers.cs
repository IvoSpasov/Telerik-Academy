using System;

class DrunkenNumbers
{
    static void Main()
    {
        int totalRounds = int.Parse(Console.ReadLine());

        if ((totalRounds >= 1) && (totalRounds <= 100))
        {
            int sumMitko = 0, sumVladko = 0;

            for (int x = 1; x <= totalRounds; x++)
            {
                long n = Math.Abs(int.Parse(Console.ReadLine()));
                string number = Convert.ToString(n);
                int numberLenght = number.Length;
                int numberHalfLenght;
                if (numberLenght % 2 == 0)
                {
                    numberHalfLenght = numberLenght / 2;
                }
                else
                {
                    numberHalfLenght = (numberLenght / 2) + 1;
                }

                int[] array = new int[numberLenght];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(new string(number[i], 1));
                }

                for (int i = 0; i < numberHalfLenght; i++)
                {
                    sumMitko += array[i];
                }

                for (int i = numberLenght / 2; i < array.Length; i++)
                {
                    sumVladko += array[i];
                }
            }


            if (sumMitko < sumVladko)
            {
                Console.WriteLine("V " + (sumVladko - sumMitko));
            }
            else if (sumMitko > sumVladko)
            {
                Console.WriteLine("M " + (sumMitko - sumVladko));
            }
            else
            {
                Console.WriteLine("No " + (sumVladko + sumMitko));
            }

        }
    }
}

// Score 100/100