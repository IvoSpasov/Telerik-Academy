// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their binary representation.");
        Console.Write("Please enter a decimal number: ");
        long decimalNumber = 0;

        while (!(long.TryParse(Console.ReadLine(), out decimalNumber)))
        {
            Console.Write("Please enter a valid decimal number: ");
        }

        long decimalNumberCopy = decimalNumber;
        byte remainder = 0;
        List<byte> remaindersArray = new List<byte>();

        while (decimalNumber != 0)
        {
            remainder = Convert.ToByte(decimalNumber % 2);
            decimalNumber /= 2;
            remaindersArray.Add(remainder);
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

        Console.WriteLine("The number \"{0}\" looks like \"{1}\" in binary representation.", decimalNumberCopy, result);

        // Second (shorter) way
        result = Convert.ToString(decimalNumberCopy, 2);
        Console.WriteLine("The number \"{0}\" looks like \"{1}\" in binary representation.", decimalNumberCopy, result);
    }
}

