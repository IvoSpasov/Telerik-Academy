using System;

    class IntigerDivision
    {
        static void Main()
        {
            int num;

            Console.WriteLine("This program tells you whether the number you've typed in can be divided\n"
                + "without reminder by 7 and 5 at the same time.");
            Console.Write("Please type in an integer number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("The number can be divided by 7 and 5 at the same time.");
            }
            else
            {
                Console.WriteLine("The number can NOT be divided by 7 and 5 at the same time.");
            }
        }
    }

