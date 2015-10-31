using System;

    class Program
    {
        static void Main()
        {
            int a, b, c;
            double discriminant, x1, x2;
            bool parseSuccess = true;

            Console.WriteLine("This program solves the quadratic equation ax^2 + bx + c = 0.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a valid value for coefficent \"a\": ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out a)) && (a != 0);
                }
                else
                {
                    Console.Write("Please type in coefficent \"a\": ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out a)) && (a != 0);
                }

            } while (parseSuccess == false);

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a valid value for coefficent \"b\": ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out b);
                }
                else
                {
                    Console.Write("Please type in coefficent \"b\": ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out b);
                }

            } while (parseSuccess == false);

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a valid value for coefficent \"c\": ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out c);
                }
                else
                {
                    Console.Write("Please type in coefficent \"c\": ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out c);
                }

            } while (parseSuccess == false);
            
            discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine();
                Console.WriteLine("x1 = {0:0.000}", x1);
                Console.WriteLine("x2 = {0:0.000}", x2);
                Console.WriteLine();
            }
            else if (discriminant == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine();
                Console.WriteLine("x1 = x2 = {0:0.00}", x1);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There are no real roots. There are two complex roots.");
                Console.WriteLine();
            }

        }
    }

