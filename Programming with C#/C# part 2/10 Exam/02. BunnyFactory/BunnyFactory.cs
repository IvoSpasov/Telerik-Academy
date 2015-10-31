namespace _02.BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Numerics;

    class BunnyFactory
    {
        static void Main()
        {
            List<int> cages = ReadCages();
            int counter = 1;

            while(counter < cages.Count)
            {
                int initialSum = 0;
                int secondSum = 0;
                BigInteger product = 1;

                for (int i = 0; i < counter; i++)
                {
                    initialSum += cages[i];
                }

                if (initialSum > cages.Count)
                {
                    break;
                }

                for (int j = counter; j < counter + initialSum; j++)
                {
                    secondSum += cages[j];
                    product *= (cages[j]);
                }

                StringBuilder nextCages = new StringBuilder();
                nextCages.Append(secondSum);
                nextCages.Append(product);

                for (int k = counter + initialSum; k < cages.Count; k++)
                {
                    nextCages.Append(cages[k]);
                }

                cages.Clear();

                for (int l = 0; l < nextCages.Length; l++)
                {
                    if (nextCages[l] != '0' && nextCages[l] != '1')
                    {
                        cages.Add(int.Parse(nextCages[l].ToString()));
                    }                    
                }

                counter++;
            }

            Console.WriteLine(string.Join(" ", cages));
        }

        static List<int> ReadCages()
        {
            List<int> cages = new List<int>();

            string currentRow;

            while ((currentRow = Console.ReadLine()) != "END")
            {
                cages.Add(int.Parse(currentRow));
            }

            return cages;
        }
    }
}
