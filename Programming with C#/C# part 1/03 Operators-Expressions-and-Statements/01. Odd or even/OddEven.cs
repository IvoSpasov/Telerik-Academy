using System;

    class OddEven
    {
        static void Main()
        {
            int num;

            Console.WriteLine("This program tells you whether the number you've typed in is even or odd.");
            Console.Write("Please type in an integer number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }

