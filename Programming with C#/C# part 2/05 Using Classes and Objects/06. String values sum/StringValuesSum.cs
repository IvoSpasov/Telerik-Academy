//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function 
// that reads these values from given string and calculates their sum. Example: string = "43 68 9 23 318" -> result = 461

using System;

class StringValuesSum
{
    static double CalcSumFromString(string values)
    {
        string[] numbersAsStrings = values.Split(' ');
        double sum = 0;

        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            sum += double.Parse(numbersAsStrings[i]);
        }
        return sum;
    }

    static void Main()
    {
        string a = "43 68 9 23 318";
        double sum = CalcSumFromString(a);
        Console.WriteLine("The sum is: " + sum);
    }
}

