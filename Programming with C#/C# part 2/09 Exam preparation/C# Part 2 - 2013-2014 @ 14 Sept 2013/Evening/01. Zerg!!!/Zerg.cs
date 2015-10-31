using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zerg
{
    static void Main()
    {
        //string[] messageArray = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", 
        //                    "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        //string input = Console.ReadLine();
        //string[] inputArray = new string[input.Length / 4];
        //int startIndex = 0;
        //long sum = 0;
        //int number = 0;

        //for (int i = 0; i < inputArray.Length; i++)
        //{
        //    inputArray[i] = input.Substring(startIndex, 4);
        //    startIndex += 4;
        //    number = Array.IndexOf(messageArray, inputArray[i]);
        //    sum += (number * Convert.ToInt64(Math.Pow(15, inputArray.Length - i - 1)));
        //}
        //Console.WriteLine(sum);


        string[] messageArray = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", 
                            "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        string input = Console.ReadLine();
        string word = string.Empty;
        long sum = 0;
        int number = 0;

        for (int i = 0, j = 0; i < input.Length; i += 4, j++)
        {
            word = input.Substring(i, 4);
            number = Array.IndexOf(messageArray, word);
            sum += (number * Convert.ToInt64(Math.Pow(15, (input.Length / 4) - j - 1)));
        }
        Console.WriteLine(sum);
    }
}

// 100/100
    