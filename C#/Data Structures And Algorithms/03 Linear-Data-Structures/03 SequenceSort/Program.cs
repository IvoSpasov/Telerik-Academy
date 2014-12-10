// Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

namespace _03_SequenceSort
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer number or nothing to stop: ");
            int currentNumber;
            string command;
            var sequence = new List<int>();

            while ((command = Console.ReadLine()) != string.Empty)
            {
                while (!(int.TryParse(command, out currentNumber)))
                {
                    Console.Write("The number must be valid: ");
                    command = Console.ReadLine();
                }

                sequence.Add(currentNumber);
                Console.Write("Please enter an integer number or nothing to stop: ");
            }

            sequence.Sort();
            Console.WriteLine("The sorted sequence is: " + string.Join(", ", sequence));
        }
    }
}
