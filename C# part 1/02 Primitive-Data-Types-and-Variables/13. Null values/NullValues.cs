using System;


    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a += 5;
            b += 10.5135;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a += null;
            b += null;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
