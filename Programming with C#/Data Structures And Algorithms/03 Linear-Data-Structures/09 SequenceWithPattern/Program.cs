// Using the Queue<T> class write a program to print its first 50 members for given N.
//S1 = N;
//S2 = S1 + 1;
//S3 = 2*S1 + 1;
//S4 = S1 + 2;
//S5 = S2 + 1;
//S6 = 2*S2 + 1;
//S7 = S2 + 2;

namespace _09_SequenceWithPattern
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var result = CalculateSequence(2);
            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> CalculateSequence(int number)
        {
            Queue<int> queue = new Queue<int>();
            List<int> sequence = new List<int>();
            queue.Enqueue(number);
            int numberOfMembers = 50;

            while (sequence.Count < numberOfMembers)
            {
                queue.Enqueue(queue.Peek() + 1);
                queue.Enqueue(2 * queue.Peek() + 1);
                queue.Enqueue(queue.Peek() + 2);
                sequence.Add(queue.Dequeue());
            }

            return sequence;
        }
    }
}