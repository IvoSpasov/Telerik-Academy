using System;

    class ThirdDigit
    {
        static void Main()
        {
            int num;

            Console.WriteLine("This program checks if the third digit (from right to left) of an intiger value\nis 7.");
            Console.Write("Please type in a number: ");
            num = Math.Abs(int.Parse(Console.ReadLine()));
            num /= 100;
            num %= 10;

            if (num == 7)
            {
                Console.WriteLine("The third digit is 7.");
            }
            else
            {
                Console.WriteLine("The third digit is NOT 7.");
            }
            
        }
    }

