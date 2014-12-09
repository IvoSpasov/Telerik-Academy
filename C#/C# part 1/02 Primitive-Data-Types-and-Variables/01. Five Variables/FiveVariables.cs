using System;


    class FiveVariables
    {
        static void Main()
        {
            ushort a = 52130;
            Console.WriteLine("Our number = " + a);
            Console.WriteLine("Max value = " + ushort.MaxValue);
            Console.WriteLine();
         
            sbyte b = -115;
            Console.WriteLine("Our number = " + b);
            Console.WriteLine("Min value = " + sbyte.MinValue);
            Console.WriteLine();

            int c = 4825932;
            Console.WriteLine("Our number = " + c);
            Console.WriteLine("Max value = " + int.MaxValue);
            Console.WriteLine();

            byte d = 92;
            Console.WriteLine("Our number = " + d);
            Console.WriteLine("Max value = " + byte.MaxValue);
            Console.WriteLine();

            short e = - 10000;
            Console.WriteLine("Our number = " + e);
            Console.WriteLine("Min value = " + short.MinValue);
            Console.WriteLine();

            //I'm (visually) comparing the value of the numbers with the min or max value of the given 
            //type which I've chosen just for the fun of it. The comparison is on two seperate rows.
        }
    }

