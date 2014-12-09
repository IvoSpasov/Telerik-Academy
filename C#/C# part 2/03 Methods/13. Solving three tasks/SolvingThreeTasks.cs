// Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Threading;
using System.Globalization;

class SolvingThreeTasks
{
    static decimal ReverseNumber(decimal number)
    {
        string numberAsString = number.ToString();
        string[] array = new string[numberAsString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToString(numberAsString[numberAsString.Length - i - 1]);
        }

        string reversedNumberAsString = string.Join("", array);
        decimal reversedNumber = decimal.Parse(reversedNumberAsString);
        return reversedNumber;
    }

    static bool SequenceAverage(string sequence)
    {
        string[] separators = { " ", ", ", ",", " ,", "\t" };
        string[] sequenceStrArray = sequence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] sequenceIntArray = new int[sequenceStrArray.Length];
        bool check = true;
        double sum = 0;
        double counter = 0;
        bool emptyIntArray = false;

        for (int i = 0; i < sequenceIntArray.Length; i++)
        {
            check = int.TryParse(sequenceStrArray[i], out sequenceIntArray[i]);

            if (!check)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("The element \"");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sequenceStrArray[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\" is not a valid integer number.");
            }
            else
            {
                sum += sequenceIntArray[i];
                counter++;
            }
        }

        if (counter == 0)
        {
            emptyIntArray = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The result is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sum / counter);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        return emptyIntArray;
    }

    static double LinearEquation(double a, double b)
    {
        double result = 0;
        result = (b / a) * (-1);
        return result;
    }


    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Options list:");
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculate the average of a sequence of integers.");
        Console.WriteLine("3. Calculate x in the linear equation a * x + b = 0.");

        byte choice = 0;
        Console.Write("Please type in a choice from 1 to 3: ");
        Console.ForegroundColor = ConsoleColor.Green;
        while (!(byte.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice < 4))
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please type in a choice from 1 to 3 in the correct format: ");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.ForegroundColor = ConsoleColor.Gray;
        if (choice == 1)
        {
            decimal numberToReverse = 0;
            Console.Write("Please type in a number (n > 0): ");
            Console.ForegroundColor = ConsoleColor.Green;
            while (!(decimal.TryParse(Console.ReadLine(), out numberToReverse) && numberToReverse >= 0))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please type in a number in the correct format: ");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The result is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ReverseNumber(numberToReverse));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if (choice == 2)
        {
            Console.WriteLine("Please type in the sequence using spaces or commas between the numbers:");
            Console.ForegroundColor = ConsoleColor.Green;
            bool check = SequenceAverage(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            while (check)
            {
                Console.WriteLine("The sequnce is empty. Please type in a new one:");
                Console.ForegroundColor = ConsoleColor.Green;
                check = SequenceAverage(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        else if (choice == 3)
        {
            Console.Write("Please type in \"a\": ");
            int a = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (!(int.TryParse(Console.ReadLine(), out a) && a > 0))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please type in \"a\" in the correct format (a > 0): ");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please type in \"b\": ");
            int b = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (!(int.TryParse(Console.ReadLine(), out b)))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please type in \"b\" in the correct format: ");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("The resul (x) is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0:F3}", LinearEquation(a, b));
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
