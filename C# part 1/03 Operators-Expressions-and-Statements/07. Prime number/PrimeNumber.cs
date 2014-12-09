using System;

class PrimeNumber
{
    static void Main()
    {
        int num;

        Console.WriteLine("This program tells you whether the number you've entered is a prime or not.");
        Console.Write("Please type in an integer number: ");
        num = int.Parse(Console.ReadLine());

        if (num <= 100)
        {
            if (((num != 1) && (num % 2 != 0) && (num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0) && (num % 9 != 0))
            || (num == 2 || num == 3 || num == 5 || num == 7))
            {
                Console.WriteLine("The number is a prime.");
            }
            else
            {
                Console.WriteLine("The number is NOT a prime.");
            }
        }
        else
        {
            Console.WriteLine("I'm sorry but the assignment says you can enter numbers up to 100.");
        }

        for (int i = 0; i < 100; i++)
        {
            if (((i != 1) && (i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0) && (i % 9 != 0)) ||
                (i == 2 || i == 3 || i == 5 || i == 7))
            {
                Console.WriteLine(i);
            }
        }
    }
}

//  I belive that this is a faster way than using a loop.