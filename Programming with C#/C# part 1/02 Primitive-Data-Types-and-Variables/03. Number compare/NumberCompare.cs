using System;


    class NumberCompare
    {
        static void Main()
        {
            float num1, num2;


            Console.WriteLine("This program compares two real numbers with precision up to the 7th sign\n" +
                "after the deciaml point.");
            Console.WriteLine();
            Console.Write("Please enter the first number you want to compare: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number you want to compare: ");
            num2 = float.Parse(Console.ReadLine());


            if (Math.Abs(num1 - num2) < 0.000001)
            {
                Console.WriteLine("True. The numbers you've entered are equal.");
            }
            else
            {
                Console.WriteLine("False. The numbers you've entered are not equal.");
            }


        }
    }

