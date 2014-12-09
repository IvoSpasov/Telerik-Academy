using System;

    class SubsetSums
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < numbers.Length; i++)
			{
			    numbers[i] = long.Parse(Console.ReadLine());
			}

            int sumCounter = 0;
            int combinations = (int)Math.Pow(2, n);

            for (int i = 0; i < combinations; i++)
            {
                long tempSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    //bit = ((1 << j) & i) >> j; 

                }
                
            }
        }
    }

