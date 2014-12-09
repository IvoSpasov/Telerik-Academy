using System;

    class SumCheck
    {
        static void Main()
        {
            // int a = 3, b = -3, c = 1, d = -1, e = 0;
            int a = 3, b = -2, c = 1, d = 1, e = 8;

            
            if (a + b + c + d + e == 0) // 01
            {
                Console.WriteLine("a + b + c + d + e = 0");
            }
            if (a + b + c + d == 0) // 02
            {
                Console.WriteLine("a + b + c + d = 0");
            }
            if (a + b + c + e == 0) // 03
            {
                Console.WriteLine("a + b + c + e = 0");
            }
            if (a + b + d + e == 0) // 04
            {
                Console.WriteLine("a + b + d + e = 0");
            }
            if (a + c + d + e == 0) // 05
            {
                Console.WriteLine("a + c + d + e = 0");
            }
            if (b + c + d + e == 0) // 06
            {
                Console.WriteLine("b + c + d + e = 0");
            }
            if (a + b + c == 0) // 07
            {
                Console.WriteLine("a + b + c = 0");
            }
            if (b + c + d == 0) // 08
            {
                Console.WriteLine("b + c + d = 0");
            }
            if (c + d + e == 0) // 09
            {
                Console.WriteLine("c + d + e = 0");
            }
            if (a + c + d == 0) // 10
            {
                Console.WriteLine("a + c + d = 0");
            }
            if (b + d + e == 0) // 11
            {
                Console.WriteLine("b + d + e = 0");
            }
            if (c + e + a == 0) // 12
            {
                Console.WriteLine("c + e + a = 0");
            }
            if (d + a + b == 0) // 13
            {
                Console.WriteLine("d + a + b = 0");
            }
            if (e + b + c == 0) // 14
            {
                Console.WriteLine("e + b + c = 0");
            }
            if (a + d + e == 0) // 15
            {
                Console.WriteLine("a + d + e = 0");
            }
            if (b + e + a == 0) // 16
            {
                Console.WriteLine("b + e + a = 0");
            }
            if (a + b == 0) // 17
            {
                Console.WriteLine("a + b = 0");
            }
            if (a + c == 0) // 18
            {
                Console.WriteLine("a + c = 0");
            }
            if (a + d == 0) // 19
            {
                Console.WriteLine("a + d = 0");
            }
            if (a + e == 0) // 20
            {
                Console.WriteLine("a + e = 0");
            }
            if (b + c == 0) // 21
            {
                Console.WriteLine("b + c = 0");
            }
            if (b + d == 0) // 22
            {
                Console.WriteLine("b + d = 0");
            }
            if (b + e == 0) // 23
            {
                Console.WriteLine("b + e = 0");
            }
            if (c + d == 0) // 24
            {
                Console.WriteLine("c + d = 0");
            }
            if (c + e == 0) // 25
            {
                Console.WriteLine("c + e = 0");
            }
            if (d + e == 0) // 26
            {
                Console.WriteLine("d + e = 0");
            }
        }
    }

