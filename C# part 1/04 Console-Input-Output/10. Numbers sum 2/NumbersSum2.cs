using System;

    class NumbersSum2
    {
        static void Main()
        {
            int n;
            double sum = 2, member = 1, denominator = 1;
            bool parseSuccess = true;

            Console.WriteLine("This program calculates the sum of the sequence:\n\"1 + 1/2 - 1/3 + 1/4 - 1/5 + ...1/n\"");
            

             do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in the sequence lenght (n) in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out n);
                }
                else
                {
                    Console.Write("Please type in the sequence lenght (n): ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out n);    
                }
            } while (parseSuccess == false);


            for (int i = 0; i < n; i++)
            {
                member = 1 / denominator;
                
                if (denominator % 2 == 0)
                {
                    sum += member; 
                }
                else if (denominator % 2 != 0)
                {
                    sum -= member;
                }

                denominator++;
                
                //Console.WriteLine("{0:0.000}", sum);
                // This line is left on purpose. If you like you can see the sum of the numbers every time sum is performed.
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: {0:0.000}", sum);
            // Otherwise you see only the end result (sum).
            Console.WriteLine();
        }
    }

