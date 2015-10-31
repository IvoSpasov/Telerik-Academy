using System;

class ForestRoad
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = (2 * width) - 1;
        int a = 0;
        int b = width - 1;

        for (int i = 1; i <= height; i++)
        {
            string dot = new string('.', a);
            Console.Write(dot);
            Console.Write("*");
            dot = new string('.', b);
            Console.Write(dot);

            if (i <= height / 2)
            {
                a++;
                b--;
            }
            else
            {
                a--;
                b++;
            }
            Console.WriteLine();
        }
    }
}

// Score 100/100