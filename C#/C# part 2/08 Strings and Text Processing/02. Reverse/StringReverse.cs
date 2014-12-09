// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample" -> "elpmas".

using System;
using System.Text;

class StringReverse
{
    static void Main()
    {
        string str = "sample";
        StringBuilder builderA = new StringBuilder();
        StringBuilder builderB = new StringBuilder();
        builderA.Append(str);
        for (int i = builderA.Length - 1; i >= 0; i--)
        {
            builderB.Append(builderA[i]);
        }
        Console.WriteLine("Before:");
        Console.WriteLine(str);
        Console.WriteLine("After:");
        Console.WriteLine(builderB.ToString());
    }
}