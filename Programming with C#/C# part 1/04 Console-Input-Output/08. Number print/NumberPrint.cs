using System;

    class NumberPrint
    {
        static void Main()
        {
            int n;
            bool parseSuccess = true;

            Console.WriteLine("This program reads an integer number \"n\" from the console and" + 
                " prints all the\nnumbers in the interval [1..n], each on a single line.");

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a valid integer number: ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out n)) && (n != 0) && (n != 1);
                }
                else
                {
                    Console.Write("Please type in how many numbers you will print: ");
                    parseSuccess = (int.TryParse(Console.ReadLine(), out n)) && (n != 0) && (n != 1);
                }

            } while (parseSuccess == false);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
            }
       
        }
    }

