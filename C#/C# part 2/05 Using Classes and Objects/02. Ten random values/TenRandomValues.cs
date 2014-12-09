// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class TenRandomValues
{
    static void Main()
    {
        Random rnd = new Random();

        for (int i = 1; i <= 10; i++)
        {
            int rndNumber = rnd.Next(100, 201);
            Console.Write(rndNumber + ", ");
        }
        Console.WriteLine("\b\b ");
    }
}
