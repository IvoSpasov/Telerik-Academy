// Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
// percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class NumberRepresentation
{
    static void Main()
    {
        int number = 125;
        string numberToHex = String.Format("{0:X}", number);
        string numberToPercent = String.Format("{0:P}", number);
        string numberToScientific = String.Format("{0:E}", number);

        Console.WriteLine(number.ToString().PadLeft(15));
        Console.WriteLine(numberToHex.PadLeft(15));
        Console.WriteLine(numberToPercent.PadLeft(15));
        Console.WriteLine(numberToScientific.PadLeft(15));
    }
}