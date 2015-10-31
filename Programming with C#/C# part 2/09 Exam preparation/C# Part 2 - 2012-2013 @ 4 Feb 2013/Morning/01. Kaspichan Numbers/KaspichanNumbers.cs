using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Kaspichan_Numbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong decimalNumber = ulong.Parse(Console.ReadLine());
            string[] array = new string[256];
            char capitalLetter = 'A';
            char smalLetter = 'a';

            for (int i = 0; i <= 25; i++)
            {
                array[i] = capitalLetter.ToString();
                capitalLetter++;
            }

            capitalLetter = 'A';

            for (int i = 26; i < array.Length; i++)
            {
                array[i] = smalLetter.ToString() + capitalLetter.ToString();
                capitalLetter++;

                if ((i + 1) % 26 == 0)
                {
                    capitalLetter = 'A';
                    smalLetter++;
                }
            }

            ulong remainder = 0;
            List<string> remaindersArray = new List<string>();

            if (decimalNumber != 0)
            {
                while (decimalNumber != 0)
                {
                    remainder = decimalNumber % 256;
                    decimalNumber /= 256;
                    remaindersArray.Add(array[remainder]);
                }
            }
            else
            {
                remaindersArray.Add("A");
            }

            remaindersArray.Reverse();
            string result = string.Join("", remaindersArray);
            Console.WriteLine(result);
        }
    }
}
