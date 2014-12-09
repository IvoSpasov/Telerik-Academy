using System;

    class ThirdBit
    {
        static void Main()
        {
            int num, x; // I can also use only one variable in this program.

            Console.WriteLine("This program finds out whether the third bit of an integer number is \n\"0\" or \"1\".");
            Console.Write("Please type in a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Which in binary numerial system is: ");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));

            x = num & 8; // x will be either 0000 or 1000

            if (x != 0) // if (x == 8) is also possible
            {
                Console.WriteLine("The third bit of the number is \"1\".");     
            }
            else
            {
                Console.WriteLine("The third bit of the number is \"0\".");
            }
        
        }
    }

