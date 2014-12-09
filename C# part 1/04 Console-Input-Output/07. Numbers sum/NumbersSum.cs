using System;
using System.Threading;
using System.Globalization;


    class NumbersSum
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n;
            float numberOld, numberNew = 0;
            bool parseSuccess = true;

            Console.WriteLine("This program gets a number \"n\" and after that gets more \"n\" numbers and\n"
                + "calculates and prints their sum.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a valid integer number: ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out n)) && (n != 0) && (n != 1);
                }
                else
                {
                    Console.Write("Please type in how many numbers you will sum: ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out n)) && (n != 0) && (n != 1);                    
                }

            } while (parseSuccess == false);

            for (int i = 0; i < n; i++)
            {
                do
                {
                    if (parseSuccess == false)
                    {
                        Console.Write("Please enter valid number {0}: ", i+1);
                        parseSuccess = float.TryParse(Console.ReadLine(), out numberOld);
                    }
                    else
                    {
                        Console.Write("Please enter number {0}: ", i+1);
                        parseSuccess = float.TryParse(Console.ReadLine(), out numberOld);                        
                    }
                    
                } while (parseSuccess == false);

                numberNew += numberOld;

            }
            Console.WriteLine();
            Console.WriteLine("The sum of the {0} numbers is: {1:F}", n, numberNew);
            Console.WriteLine();
        }
    }

