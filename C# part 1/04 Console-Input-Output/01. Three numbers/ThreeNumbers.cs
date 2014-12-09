using System;

    class ThreeNumbers
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0;
            bool parseSuccess = false;
            
            Console.WriteLine("This program sums three integer numbers.");
            while (!parseSuccess)
            {
                Console.Write("Plese type in the first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out a);
            }
            parseSuccess = false;
            while (!parseSuccess)
            {
                Console.Write("Plese type in the second number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out b);
            }
            parseSuccess = false;
            while (!parseSuccess)
            {
                Console.Write("Plese type in the third number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out c);
            }
            
            Console.WriteLine("The sum of the numbers is: " + (a+b+c));
        }
    }

