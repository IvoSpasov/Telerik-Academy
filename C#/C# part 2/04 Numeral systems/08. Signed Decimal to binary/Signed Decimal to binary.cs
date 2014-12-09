// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program converts 16-bits signed numbers to their binary representation.");
        Console.Write("Please enter a decimal number: ");
        short decimalNumber = 0;

        while (!(short.TryParse(Console.ReadLine(), out decimalNumber)))
        {
            Console.Write("Please enter a valid decimal number: ");
        }

        short decimalNumberCopy = decimalNumber;
        byte remainder = 0;
        List<byte> remaindersArray = new List<byte>();
        string result = string.Empty;

        int[] binaryArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int counter = 0;

        if (decimalNumber > 0)
        {
            while (decimalNumber != 0)
            {
                remainder = Convert.ToByte(decimalNumber % 2);
                decimalNumber /= 2;
                remaindersArray.Add(remainder);
            }

            remaindersArray.Reverse();
            result = string.Join("", remaindersArray);
        }

        else if (decimalNumber < 0)
        {
            decimalNumber *= -1;
            decimalNumber--;

            while (decimalNumber != 0)
            {
                remainder = Convert.ToByte(decimalNumber % 2);
                remainder ^= 1;
                decimalNumber /= 2;
                binaryArray[binaryArray.Length - counter - 1] = remainder;
                counter++;
            }

            result = string.Join("", binaryArray);
        }

        else
        {
            result = "0";
        }

        Console.WriteLine("The number \"{0}\" looks like \"{1}\" in binary representation.", decimalNumberCopy, result);
    }
}

// Yes the logic is crazy but at least it's mine (like the logic in the rest of the tasks). 
// And yes there are solutions placed in 10 lines of code doing the same thing :)
