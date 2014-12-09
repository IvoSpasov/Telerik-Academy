// Write a program that reads from the console a string of maximum 20 characters. If the length of 
// the string is less than 20, the rest of the characters should be filled with '*'. Print the result
// string into the console

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        Console.WriteLine("Please type in any text: ");
        string a = Console.ReadLine();

        if (a.Length > 20)
        {
            text.Append(a, 0, 20);
        }
        else
        {
            text.Append(a);
        }

        while (text.Length < 20)
        {
            text.Append("*");
        }

        Console.WriteLine("The result is: ");
        Console.WriteLine(text.ToString());
    }
}

