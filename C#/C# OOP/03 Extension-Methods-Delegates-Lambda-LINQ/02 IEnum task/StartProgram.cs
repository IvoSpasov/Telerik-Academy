// Task 2 -> Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
// sum, product, min, max, average.

namespace _02_IEnum_task
{
    using System;
    using System.Collections.Generic;

    public class StartProgram
    {
        public static void Main()
        {
            var list = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("In the collection: ");
            Console.WriteLine("The sum is: " + list.Sum());
            Console.WriteLine("The product is: " + list.Product());
            Console.WriteLine("The min value is: " + list.Min());
            Console.WriteLine("The max value is: " + list.Max());
            Console.WriteLine("The average is: " + list.Average());
        }
    }
}
