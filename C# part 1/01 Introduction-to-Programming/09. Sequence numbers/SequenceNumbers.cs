using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sequence_numbers
{
    class SequenceNumbers
    {
        static void Main()
        {
            for (int even = 2, odd = -3; even < 12; even += 2, odd -= 2)
            {
                Console.Write(even + ", ");
                
                Console.Write(odd);

                if (even < 11)
                {
                    Console.Write(", ");
                }
                //Console.Write("{0}, {1}, ", even, odd);
            }
            //Console.WriteLine("\b\b  ");
            Console.WriteLine();
        }
    }
}