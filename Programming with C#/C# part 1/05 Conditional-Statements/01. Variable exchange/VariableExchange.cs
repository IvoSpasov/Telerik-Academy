using System;

    class VariableExchange
    {
        static void Main()
        {
            int a, b, temp;
            bool parseSuccess = true;

            Console.WriteLine("This program examines two integer variables and exchanges their values if the\n" + 
                "first one is greater than the second one.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the first variable (a) in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out a);
                }
                else
                {
                    Console.Write("Please type in the first variable (a): ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out a);
                }

            } while (parseSuccess == false);
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the second variable (b) in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out b);
                }
                else
                {
                    Console.Write("Please type in the second variable (b): ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out b);
                }

            } while (parseSuccess == false);

            if (b < a)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }

