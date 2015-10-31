// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their hexadecimal representation.");
        Console.Write("Please enter a decimal number: ");
        long decimalNumber = 0;

        while (!(long.TryParse(Console.ReadLine(), out decimalNumber)))
        {
            Console.Write("Please enter a valid decimal number: ");
        }
        long decimalNumberCopy = decimalNumber;
        byte remainder = 0;
        List<string> remaindersArray = new List<string>();

        while (decimalNumber != 0)
        {
            remainder = Convert.ToByte(decimalNumber % 16);
            decimalNumber /= 16;

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
        
        Console.WriteLine("The number \"{0}\" looks like \"{1}\" in hexadecimal representation.", decimalNumberCopy, result);

        // Second (shorter) way
        result = decimalNumberCopy.ToString("X");
        Console.WriteLine("The number \"{0}\" looks like \"{1}\" in hexadecimal representation.", decimalNumberCopy, result);
    }
}
