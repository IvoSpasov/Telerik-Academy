using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            int a, b, min, max, result = 0, reminder = 0;

            Console.WriteLine("This program calculates the greatest common divisor (GCD) of given two numbers.");
            Console.Write("Please type in the first number: ");
            while (!(int.TryParse(Console.ReadLine(), out a)))
            {
                Console.Write("Please type in the first number in the correct format: ");
            }

            Console.Write("Please type in the second number in the correct format: ");
            while (!(int.TryParse(Console.ReadLine(), out b)))
            {
                Console.Write("Please type in the second number in the correct format: ");
            }
            
            max = Math.Max(a, b);
            min = Math.Min(a, b);

            do
            {
                result = max / min;
                reminder = max % min;
                max = min;
                min = reminder;

            } while (reminder != 0);
            Console.WriteLine("The result is: " + max);
        }
    }

