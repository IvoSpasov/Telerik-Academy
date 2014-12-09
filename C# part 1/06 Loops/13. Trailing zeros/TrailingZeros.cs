using System;

    class TrailingZeros
    {
        static void Main()
        {
            int n, result = 0;

            Console.WriteLine("This program calculates for given N how many trailing zeros are present at\n"
                + "the end of the number N!");
            Console.Write("Please type in \"N\": ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n >= 0)))
            {
                Console.Write("Please type in \"N\" in the correct format: ");
            }
            
            for (int x = 5; x <= n; x *= 5)
			{
               result += n / x;
			}
            
            Console.WriteLine("The result is: " + result + " zeros.");
            
        }
    }

