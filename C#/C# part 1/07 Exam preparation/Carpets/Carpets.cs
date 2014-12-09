using System;

class Carpets
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int elementsOnRow = rows;
        int center = elementsOnRow / 2;
        string dot;

        for (int i = 1; i <= rows / 2; i++)
        {

            dot = new string('.', center - i);
            Console.Write(dot);

            for (int j = 0; j < i; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int j = i; j > 0; j--)
            {
                if (j % 2 != 0)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write(dot);
            Console.WriteLine();
        }

        // second part
        if (center % 2 == 0)
        {
            for (int i = 0; i < rows / 2; i++)
            {
                dot = new string('.', i);
                Console.Write(dot);

                for (int j = center; j > i; j--)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = i; j < center; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write(dot);
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0; i < rows / 2; i++)
            {
                dot = new string('.', i);
                Console.Write(dot);

                for (int j = center; j > i; j--)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = i; j < center; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write(dot);
                Console.WriteLine();
            }
        }
    }
}

// Score 100/100