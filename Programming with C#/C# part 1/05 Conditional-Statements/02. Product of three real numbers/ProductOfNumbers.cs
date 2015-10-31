using System;

    class ProductOfNumbers
    {
        static void Main()
        {
            int a = 1, b = -2, c = -1; // You can change the value of the variables here.
            int counter = 0;

            if (a != 0 && b != 0 && c != 0)
            {
                if (a < 0)
                {
                    counter++;
                }
                if (b < 0)
                {
                    counter++;
                }
                if (c < 0)
                {
                    counter++;
                }
                // Up to here we check whteher the numbers are negative. 
                // And then we check if the "counter" has an odd or even value. Depending on it the sign will be different.
                if (counter % 2 == 0)
                {
                    Console.WriteLine("The sign of the product is \"plus\".");
                }
                else
                {
                    Console.WriteLine("The sign of the product is \"minus\".");
                }
            }
            else
	        {
                Console.WriteLine("At least one number is 0. The zero has no sign.");
	        }
           
        }
    }

