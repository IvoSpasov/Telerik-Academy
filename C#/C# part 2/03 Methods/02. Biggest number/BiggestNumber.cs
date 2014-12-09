// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 
// 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class BiggestNumber
{
    static int GetMax(int a, int b)
    {
        int maxValue = a;

        if (b > a)
        {
            maxValue = b;
        }
        return maxValue; 
    }

    static void Main()
    {
        Console.WriteLine("This program compares three integer numbers and returns the biggest one.");
        Console.Write("Please type in the first number: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Please type in the second number: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Please type in the third number: ");
        int z = int.Parse(Console.ReadLine());

        int result = GetMax(x, y);
        result = GetMax(result, z);
        Console.WriteLine("The biggest one is: " + result);
        Console.WriteLine("The biggest one is: " + GetMax(GetMax(x, y), z)); // -> shorter

    }
}

