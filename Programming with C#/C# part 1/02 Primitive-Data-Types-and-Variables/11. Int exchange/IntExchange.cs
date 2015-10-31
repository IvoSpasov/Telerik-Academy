using System;


    class IntExchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int oldA = a;

            Console.WriteLine("A old value = " + a);
            Console.WriteLine("B old value = " + b);
            Console.WriteLine();

            a = b;
            b = oldA;

            Console.WriteLine("A new value = " + a);
            Console.WriteLine("B new value = " + b);
            Console.WriteLine();

            //Surely there are other ways.
        }
    }

