// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
// Write a program to test this method.

using System;

class Hello
{
    static void TakeName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        TakeName();
    }
}

