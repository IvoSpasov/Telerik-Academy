// Task 6 -> Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _04_Numbers_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _03_Students_task; // this is the namespace from where we get the printing method

    public class StartProgram
    {
        public static void Main()
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 200; i++)
            {
                numbers.Add(i);
            }

            // with lambda expressions
            var divisibleByThreeAndSevenNumbers = numbers
                .Where(n => n % 21 == 0);

            Console.WriteLine("Using lambda expressions");
            Printing.Print(divisibleByThreeAndSevenNumbers);

            // using LINQ
            var divisibleBy =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine();
            Console.WriteLine("Using LINQ");
            Printing.Print(divisibleBy);
        }
    }
}
