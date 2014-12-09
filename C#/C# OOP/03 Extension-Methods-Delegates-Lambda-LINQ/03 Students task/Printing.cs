namespace _03_Students_task
{
    using System;
    using System.Collections.Generic;

    public class Printing
    {
        // method for printing
        public static void Print<T>(IEnumerable<T> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
