// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to hexadecimal numbers.");
        Console.Write("Please enter a binary number: ");

        string binaryNumberCopy = null;
        List<string> results = new List<string>();

        bool check = true;

        do
        {
            string binaryNumber = Console.ReadLine();
            binaryNumberCopy = binaryNumber;
            check = true;

            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                int[] binaryArray = new int[4];

                for (int j = 0; j < binaryArray.Length && i + j != binaryNumber.Length && check == true; j++)
                {
                    check = int.TryParse(binaryNumber[binaryNumber.Length - i - j - 1].ToString(), out binaryArray[binaryArray.Length - j - 1]);
                }

                if (!check)
                {
                    Console.Write("Please enter a binary number in the correct format: ");
                    break;
                }

                string fourBits = fourBits = string.Join("", binaryArray);

                switch (fourBits)
                {
                    case "0000": results.Add("0"); break;
                    case "0001": results.Add("1"); break;
                    case "0010": results.Add("2"); break;
                    case "0011": results.Add("3"); break;
                    case "0100": results.Add("4"); break;
                    case "0101": results.Add("5"); break;
                    case "0110": results.Add("6"); break;
                    case "0111": results.Add("7"); break;
                    case "1000": results.Add("8"); break;
                    case "1001": results.Add("9"); break;
                    case "1010": results.Add("A"); break;
                    case "1011": results.Add("B"); break;
                    case "1100": results.Add("C"); break;
                    case "1101": results.Add("D"); break;
                    case "1110": results.Add("E"); break;
                    case "1111": results.Add("F"); break;
                    default:
                        Console.Write("Please enter a binary number in the correct format: ");
                        check = false;
                        break;
                }
            }
        } while (!check);

        results.Reverse();
        string result = string.Join("", results);
        Console.WriteLine("The result is: " + result);

        // Second (shorter but not direct) way.
        Console.WriteLine("The result is: " + Convert.ToInt32(binaryNumberCopy, 2).ToString("X"));
    }
}
