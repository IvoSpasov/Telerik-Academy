// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigit
{
    static string LastDigitAsWord(int number)
    {
        string numberAsString = Convert.ToString(number);
        char[] myArray = numberAsString.ToCharArray();
        int lastDigit = myArray[myArray.Length - 1] - '0';
        //int lastDigit = int.Parse(Convert.ToString(myArray[myArray.Length - 1])); // both lines do the same thing.

        string lastDigitAsString = "";
        switch (lastDigit)
        {
            case 0: lastDigitAsString = "Zero"; break;
            case 1: lastDigitAsString = "One"; break;
            case 2: lastDigitAsString = "Two"; break;
            case 3: lastDigitAsString = "Three"; break;
            case 4: lastDigitAsString = "Four"; break;
            case 5: lastDigitAsString = "Five"; break;
            case 6: lastDigitAsString = "Six"; break;
            case 7: lastDigitAsString = "Seven"; break;
            case 8: lastDigitAsString = "Eight"; break;
            case 9: lastDigitAsString = "Nine"; break;
            default:
                break;
        }

        return lastDigitAsString;

    }

    static void Main()
    {
        Console.WriteLine("This program returns the last digit of given number as an English word.");
        Console.Write("Please type in a number: ");
        string result = LastDigitAsWord(int.Parse(Console.ReadLine()));
        Console.WriteLine("The last digit in the number is: " + result);
    }
}

