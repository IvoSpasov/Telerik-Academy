using System;


    class Triangle
    {
        static void Main()
        {
            //char a = '\u00A9';
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("   " + a + "\n  " + a + " " + a + "\n " + a + "   " + a + 
            //    "\n" + a + " " + a + " " + a + " " + a);

            char c = '\u00A9';

            for (int i = 0, a = 1; i < 3; i++, a++)
            {
                for (int f = 3 - i; f > 0; f -= 1)
                {
                    Console.Write(" ");
                }
                for (int g = 0; g < (i + a); g++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


        }
    }

