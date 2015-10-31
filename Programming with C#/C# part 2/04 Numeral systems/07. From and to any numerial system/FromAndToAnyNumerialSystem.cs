// Write a program to convert from any numeral system of given base s to any other numeral system of base d 
// (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

class FromAndToAnyNumerialSystem
{
    static int ToDecimal(int s)
    {
        int sum = 0;
        bool check = false;

        Console.Write("Please enter the number which will be converted : ");

        do
        {
            string SNumber = Console.ReadLine();
            int[] hexArray = new int[SNumber.Length];

            for (int i = 0; i < hexArray.Length; i++)
            {
                if ((SNumber[i] >= '0' && SNumber[i] <= '9') || (SNumber[i] >= 'A' && SNumber[i] <= 'F'))
                {
                    switch (SNumber[i])
                    {
                        case 'A': hexArray[i] = 10; break;
                        case 'B': hexArray[i] = 11; break;
                        case 'C': hexArray[i] = 12; break;
                        case 'D': hexArray[i] = 13; break;
                        case 'E': hexArray[i] = 14; break;
                        case 'F': hexArray[i] = 15; break;
                        default: hexArray[i] = int.Parse(SNumber[i].ToString()); break;
                    }
                    sum += (hexArray[i] * Convert.ToInt32(Math.Pow(s, hexArray.Length - i - 1)));
                    check = false;
                }
                else
                {
                    Console.Write("Please eneter a valid number: ");
                    check = true;
                    sum = 0; // very important line :)
                    break;
                }
            }
        } while (check);

        return sum;
    }

    static string FromDecimal(int d, long decimalNumber)
    {
        byte remainder = 0;
        List<string> remaindersArray = new List<string>();
        long decimalNumberCopy = decimalNumber;

        while (decimalNumber != 0)
        {
            remainder = Convert.ToByte(decimalNumber % d);
            decimalNumber /= d;

            switch (remainder)
            {
                case 10: remaindersArray.Add("A"); break;
                case 11: remaindersArray.Add("B"); break;
                case 12: remaindersArray.Add("C"); break;
                case 13: remaindersArray.Add("D"); break;
                case 14: remaindersArray.Add("E"); break;
                case 15: remaindersArray.Add("F"); break;
                default: remaindersArray.Add(remainder.ToString()); break;
            }
        }

        string result = string.Empty;

        if (decimalNumberCopy != 0)
        {
            remaindersArray.Reverse();
            result = string.Join("", remaindersArray);
        }

        else
        {
            result = "0";
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("This program converts a number from any numeral system with base \"s\" to any\n" +
            "other numeral system with base \"d\" (2 <= s, d <=  16).");
        Console.Write("Please enter a value for \"s\": ");
        int S = 0;
        while (!(int.TryParse(Console.ReadLine(), out S) && S >= 2 && S <= 16))
        {
            Console.Write("Please eneter a valid value for \"s\": ");
        }

        Console.Write("Please enter a value for \"d\": ");
        int D = 0;
        while (!(int.TryParse(Console.ReadLine(), out D) && D >= 2 && D <= 16))
        {
            Console.Write("Please eneter a valid value for \"d\": ");
        }

        string result = null;
        result = FromDecimal(D, ToDecimal(S));

        Console.WriteLine("The result is: " + result);
    }
}
