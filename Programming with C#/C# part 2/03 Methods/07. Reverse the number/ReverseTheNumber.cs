// Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseTheNumber
{
    static decimal ReverseNumber(decimal number)
    {
        string numberAsString = number.ToString();
        string[] array = new string[numberAsString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToString(numberAsString[numberAsString.Length - i - 1]);
        }

        string reversedNumberAsString = string.Join("", array);
        decimal reversedNumber = decimal.Parse(reversedNumberAsString);
        return reversedNumber;
    }

    static void Main()
    {
        Console.WriteLine(ReverseNumber(123.45m));
    }
}