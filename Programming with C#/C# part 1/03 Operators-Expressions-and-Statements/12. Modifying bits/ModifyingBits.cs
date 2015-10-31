using System;

    class ModifyingBits
    {
        static void Main()
        {
            int number, value, pos, posOffset;

            Console.WriteLine("This program modifies a given number bitwise. You type in the number\nand then the position" + 
                " and value of the bit you want to change.");
            Console.Write("Please type in the number you want to modify: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Please type in the position you want to modify: ");
            pos = int.Parse(Console.ReadLine());
            Console.Write("Please type in the value of the bit you want to change: ");
            value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                posOffset = 1 << pos;
                number = number | posOffset;
                Console.WriteLine("The new value of the number is: " + number);
                
            }
            else if (value == 0)
            {
                posOffset = 1 << pos;
                posOffset = ~posOffset;
                number = number & posOffset;
                Console.WriteLine("The new value of the number is: " + number);
            }
            else
            {
                Console.WriteLine("Please type in a valid value -> \"0\" or \"1\".");
            }

        }
    }

