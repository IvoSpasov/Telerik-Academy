// Write a program that reads from the console a sequence of positive integer numbers. 
// The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence.
// Keep the sequence in List<int>.

namespace _01_SumAndAverageFromSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number or nothing to stop: ");
            int currentNumber;
            string command;
            List<int> sequence = new List<int>();

            while ((command = Console.ReadLine()) != string.Empty)
            {                
                while (!(int.TryParse(command, out currentNumber)) || currentNumber < 0)
                {
                    Console.Write("The number must be positive and valid: ");
                    command = Console.ReadLine();
                }

                sequence.Add(currentNumber);
                Console.Write("Please enter a positive integer number or nothing to stop: ");
            }

            Console.WriteLine("The average of the elements is: " + sequence.Average());
            Console.WriteLine("The sum of the elements is " + sequence.Sum());
        }
    }
}
