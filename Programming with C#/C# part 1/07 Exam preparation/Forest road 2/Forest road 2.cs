using System;

class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = (2 * width) - 1;
        int a = 0;
        int b = width - 1;

        for (int i = 0; i <= height / 2; i++)
        {
            for (int ii = 1; ii <= a; ii++)
            {
                Console.Write(".");
            }

            Console.Write("*");
            for (int ii = 0; ii < b; ii++)
            {
                Console.Write(".");
            }
            a++;
            b--;
            Console.WriteLine();
        }

        a = width - 2;
        b = 1;
        for (int i = height / 2; i < height - 1; i++)
        {

            for (int ii = 0; ii < a; ii++)
            {
                Console.Write(".");
            }


            Console.Write("*");

            for (int ii = 0; ii < b; ii++)
            {
                Console.Write(".");
            }

            a--;
            b++;
            Console.WriteLine();
        }
    }
}

