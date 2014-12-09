using System;


    class Program
    {
        static void Main()
        {
            int number, bit, value, bitOffset;

            Console.WriteLine("This program extrats from a given integer the value of a given bit number.");
            Console.Write("Please type in the value of the number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Please type in the value of the postion you want to check: ");
            bit = int.Parse(Console.ReadLine());

            bitOffset = 1 << bit;
            value = number & bitOffset;
            value = value >> bit;

            Console.WriteLine("The value of the bit at this position is: " + value);
        }
    }

