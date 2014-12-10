// Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

namespace _02_StackReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Please enter an integer number or nothing to stop: ");
            int currentNumber;
            string command;
            var stack = new Stack<int>();
            var reversedStack = new Stack<int>();

            while ((command = Console.ReadLine()) != string.Empty)
            {
                while (!(int.TryParse(command, out currentNumber)))
                {
                    Console.Write("The number must be valid: ");
                    command = Console.ReadLine();
                }

                stack.Push(currentNumber);
                Console.Write("Please enter an integer number or nothing to stop: ");
            }

            Console.WriteLine("Forward stack: " + string.Join(", ", stack));

            while (stack.Count != 0)
            {
                reversedStack.Push(stack.Pop());
            }

            Console.WriteLine("Reversed stack: " + string.Join(", ", reversedStack));
        }
    }
}
