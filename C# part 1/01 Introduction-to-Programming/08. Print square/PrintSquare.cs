using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Print_square
{
    class PrintSquare
    {
        static void Main()
        {
            int num = 12345;
            int pow = 2;

            Console.WriteLine("The square of {0} number is: {1}", num, Math.Pow(num,pow));
        }
    }
}
