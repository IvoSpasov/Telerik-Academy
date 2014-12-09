using System;

    class PositionP
    {
        static void Main()
        {
            int value, position;

            Console.WriteLine("This program checks if the bit at a certain position (counting from \"0\" to\n\"30\")" +
                " in a given intiger number has a value of \"0\" or \"1\".");
            Console.Write("Please type in the value of the number: ");
            value = int.Parse(Console.ReadLine());

            Console.Write("Please type in the value of the position you want to check: ");
            position = int.Parse(Console.ReadLine());

            position = 1 << position; // I've decided to use the same variable "position" first to hold the number of 
            // the chosen position and then to change its value to the number with the chosen bitwise offset. The variable 
            // is of type "int" so it can hold a number with bitwise offset of up to 30 -> or 2^30.
                        
            if ((value & position) != 0) // Here we perform bitwise "&" operation and at the same time check if the returned value 
                              // is 0 or smth. else (not 0). This gives us boolean "ture" or "false" result at the end.
            {
                Console.WriteLine("True. The bit at the checked position is \"1\".");
            }
            else
	        {
                Console.WriteLine("False. The bit at the checked position is \"0\".");    
	        }

        }
    }

