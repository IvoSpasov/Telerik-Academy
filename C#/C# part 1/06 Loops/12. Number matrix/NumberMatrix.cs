using System;

    class NumberMatrix
    {
        static void Main()
        {
            int n;
            
            Console.WriteLine("This program reads from the console a positive integer number N (0 < N < 20)\n" + 
                "and outputs a matrix.");
            Console.Write("Please type in \"N\": ");
            while (!((int.TryParse(Console.ReadLine(), out n)) && (n < 20) && (n >= 0)))
            {
                Console.Write("Please type in \"N\" in the correct format: ");
            }
            
            Console.WriteLine();

            for (int column = 0; column < n; column++)
			{
                
			    for (int row = column + 1; row <= n + column; row++)
			    {
                    if (row <= 9)
                    {
                        Console.Write("0" + row + " "); // I intentionally put "zero" in front of the numbers up to 9 so that if
                    }                                   // you enter a number for "N", bigger than 5, the matrix would look sraight.
                    else                                // But you probably know this already.
                    {                                   // And yes there are other ways to fix the matrix (like I did it in task 14).
                        Console.Write(row + " ");
                    }
			        
			    }
                Console.WriteLine();
			}
            Console.WriteLine();
        }
    }

