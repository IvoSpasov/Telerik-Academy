using System;

class Tower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int x = height - 1;
        int y = 0;
        int rowCount = 1;
        int rowUpdate = 1;

        for (int row = 1; row <= height; row++)
        {
            for (int a = 0; a < x; a++)
            {
                Console.Write(".");
            }
            Console.Write("/");

            for (int b = 0; b < y; b++)
            {
                if (row == rowCount)
                {
                    Console.Write("-");

                }
                else
                {
                    Console.Write(".");
                }

            }

            if (row == rowCount)
            {
                rowCount += rowUpdate;
                rowUpdate++;
            }

            y += 2;

            Console.Write("\\");

            for (int c = 0; c < x; c++)
            {
                Console.Write(".");
            }
            x--;
            Console.WriteLine();
        }


    }
}

//score 100/100