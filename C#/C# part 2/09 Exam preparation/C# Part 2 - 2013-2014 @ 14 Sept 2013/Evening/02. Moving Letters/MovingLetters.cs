using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MovingLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        StringBuilder letters = new StringBuilder();
        int counter = 0;

        // this is too slow!  80/100 points
        //while (counter != inputArray.Length)
        //{
        //    counter = 0;
        //    for (int i = 0; i < inputArray.Length; i++)
        //    {
        //        if (inputArray[i].Length > 0)
        //        {
        //            letters.Append(inputArray[i][inputArray[i].Length - 1]);
        //            inputArray[i] = inputArray[i].Substring(0, inputArray[i].Length - 1);
        //        }
        //        else
        //        {
        //            counter++;
        //        }
        //    }
        //}

        int j = 0;

        while (counter != inputArray.Length)
        {
            counter = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > j)
                {
                    letters.Append(inputArray[i][inputArray[i].Length - j - 1]);
                }
                else
                {
                    counter++;
                }
            }
            j++;
        }

        for (int i = 0; i < letters.Length; i++)
        {
            char letter = letters[i];
            int index = 0;
            if (char.IsLower(letter))
            {
                index = letter - 'a' + 1;
            }
            else
            {
                index = letter - 'A' + 1;
            }

            index += i;

            if (index >= letters.Length)
            {
                index %= letters.Length;
            }

            letters.Remove(i, 1);
            letters.Insert(index, letter);
        }
        Console.WriteLine(letters.ToString());
    }
}

// 100/100