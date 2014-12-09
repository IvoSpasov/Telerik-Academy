// 05. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…),
// GetHashCode(), [], == and !=.

namespace _05.Task_bit_array
{
    using System;
    public class StartProgram
    {
        static void Main()
        {
            BitArray64 first = new BitArray64();
            first.arrayOfValues = new ulong[] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("First BitArray64. Testing foreach (the implementation of IEnumerable).");
            foreach (var item in first)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            first[3] = 256;

            Console.WriteLine("Testing the indexer");
            foreach (var item in first)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            BitArray64 second = new BitArray64();
            second.arrayOfValues = new ulong[] { 1, 2, 3, 256, 5, 6, 7 };

            Console.WriteLine("Second BitArray64");

            foreach (var item in second)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Are the first and second BitArrays equal?: " + first.Equals(second));

            BitArray64 third = new BitArray64();
            third.arrayOfValues = new ulong[] { 100, 2, 3, 256, 5, 6, 7 };

            Console.WriteLine("Third BitArray64");

            foreach (var item in third)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Are the first and third BitArrays equal?: " + (first == third));

            Console.WriteLine("The hash code of the first BitArray64 is: " + first.GetHashCode());
            Console.WriteLine("The hash code of the second BitArray64 is: " + second.GetHashCode());
            Console.WriteLine("The hash code of the third BitArray64 is: " + third.GetHashCode());
        }
    }
}
