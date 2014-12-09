using System;

    class BetweenNumbers
    {
        static void Main()
        {
            int num1, num2, p = 0, temp;
            bool parseSuccess = true;

            Console.WriteLine("This program reads two positive integer numbers and prints how many numbers \"p\"\n"
                + "exist between them such that the reminder of the division by 5 is 0.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the first number in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out num1);
                }
                else
                {
                    Console.Write("Please type in the first number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out num1);
                }

            } while (parseSuccess == false);

            temp = num1;

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the second number in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out num2);
                }
                else
                {
                    Console.Write("Please type in the second number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out num2);
                }

            } while (parseSuccess == false);

            for (int i = num1; i <= num2; i++)
            {
                if (num1 % 5 == 0)
                {
                    p++;
                }
                num1++;
            }

            Console.WriteLine("p({0}, {1}) = {2}", temp, num2, p);
        }
    }

