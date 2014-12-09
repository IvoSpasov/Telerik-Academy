using System;
using System.Threading;
using System.Globalization;

    class MinAndMaxNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            int count;
            double number, max = int.MinValue, min = int.MaxValue;

            Console.WriteLine("This program reads from the console a sequence of N integer numbers and returns\n" + 
                "the minimal and maximal of them.");
            Console.Write("Please type in how many numbers (N) you're going to compare: ");
            while (!((int.TryParse(Console.ReadLine(), out count)) && (count >=0)))
            {
                Console.Write("Please type in how many numbers (N) you're going to compare in the correct\nformat: ");
            }
            
            for (int i = 1; i <= count; i++)
            {
                Console.Write("Type in number {0}: ", i);
                while (!(double.TryParse(Console.ReadLine(), out number)))
                {
                    Console.Write("Type in number {0} in the correct format: ", i);
                }
                                
                if (max < number)
                {
                    max = number;
                }
                if (min > number)
                {
                    min = number;
                }
            }

            if (min == max)
            {
                Console.WriteLine("Min = Max = " + max); 
            }
            else
            {
                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + max);
            }

        }
    }

