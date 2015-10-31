using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = (n / 2) - 1;
        int y = 0;

        for (int a = 0; a < n / 2; a++)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write(".");
            }

            Console.Write("#");

            for (int i = 0; i < y; i++)
            {
                Console.Write(".");
            }
            Console.Write("#");

            for (int i = 0; i < x; i++)
            {
                Console.Write(".");
            }
            y += 2;
            x--;
            Console.WriteLine();
        }

        y = 0;
        x = n - 2;

        for (int a = 0; a < n / 4; a++)
        {
            for (int i = y; i > 0; i--)
            {
                Console.Write(".");
            }

            Console.Write("#");
            for (int i = x; i > 0; i--)
            {
                Console.Write(".");
            }

            Console.Write("#");
            for (int i = y; i > 0; i--)
            {
                Console.Write(".");
            }

            x -= 2;
            y++;
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();

        y = 0;
        x = n / 2;

        for (int a = 0; a < n / 2; a++)
        {
            for (int i = y; i > 0; i--)
            {
                Console.Write(".");
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("\\");
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("/");
            }

            for (int i = 0; i < y; i++)
            {
                Console.Write(".");
            }
            x--;
            y++;

            Console.WriteLine();
        }
    }
}

// score 100/100