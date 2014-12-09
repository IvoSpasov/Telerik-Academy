using System;
using System.Threading;
using System.Globalization;

    class VariableChoice
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            // This is so that you can use both "." and "," without getting an error message (unhandled exception).
            // But be careful because they don't do the same thing. The "," is just for better visual understanding of the number.

            int type;
            bool parseSuccess = true;

            Console.WriteLine("This program lets you input a variable with type \"int\", \"double\", or \"char\".");
            Console.WriteLine("You must type in a number form 0 to 2 to make your choice.");
            Console.WriteLine("1 -> \"int\", 2 -> \"double\", 3 -> \"char\"");

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Plaease type in a number in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out type);
                }
                else
                {
                    Console.Write("Please type in a number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out type);
                }

            } while (parseSuccess == false);

            switch (type)
            {
                case 1: 
                    int a;
                    Console.Write("Type in \"int\" variable (a): ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("a + 1 = " + (a + 1));
                    break;
                case 2: 
                    double b;
                    Console.Write("Type in \"double\" variable (b): ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("b + 1 = {0:0.00}", (b + 1));
                    break;
                case 3:
                    string c;
                    Console.Write("Type in \"string\" variable (c): ");
                    c = Console.ReadLine();
                    Console.WriteLine("c* = " + c + "*");
                    break;
                default:
                    Console.WriteLine("You must choose between numbers 1, 2 and 3.");
                    break;
            }
        }
    }

