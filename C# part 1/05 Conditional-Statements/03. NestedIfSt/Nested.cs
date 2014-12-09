using System;

class Nested
{
    static void Main()
    {
        int a = 3, b = 2, c = 1; // You can change the value of the variables here.


        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("a = biggest");
            }
            else
            {
                Console.WriteLine("c = biggest");
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("b = biggest");
            }
            else
            {
                Console.WriteLine("c = biggest");
            }
        }




        // Normally I would do it in this way but the task says that I should use nested if statements....
        //if (a > b && a > c)
        //{
        //    Console.WriteLine("a = biggest");
        //}
        //if (b > a && b > c)
        //{
        //    Console.WriteLine("b = biggest");
        //}
        //if (c > a && c > b)
        //{
        //    Console.WriteLine("c = biggest");
        //}
    }
}

