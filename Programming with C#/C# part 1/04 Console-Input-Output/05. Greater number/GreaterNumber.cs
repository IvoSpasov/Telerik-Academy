using System;
using System.Threading;
using System.Globalization;


    class GreaterNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double num1 = 5, num2 = 18;
            bool parseSuccess = true;

            Console.WriteLine("This program compares two numbers and prints the greater one.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the first number in the correct format: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out num1);
                }
                else
                {
                    Console.Write("Please type in the first number: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out num1);
                }

            } while (parseSuccess == false);

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the second number in the correct format: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out num2);
                }
                else
                {
                    Console.Write("Please type in the second number: ");
                    parseSuccess = double.TryParse(Console.ReadLine(), out num2);
                }

            } while (parseSuccess == false);

            Console.WriteLine("The greater number is: " + Math.Max(num1, num2));

        }
    }

