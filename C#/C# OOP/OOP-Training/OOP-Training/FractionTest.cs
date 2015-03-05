using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    class FractionTest
    {
        static void Main(string[] args)
        {
            Fraction fract = new Fraction("18/48");
            Console.WriteLine(fract);
            Console.WriteLine(fract.DecimalValue);
            fract.CancelFraction();
            Console.WriteLine(fract);
        }
    }
}
