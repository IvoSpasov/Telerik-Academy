using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.How_old_you_will_be
{
    class HowOld
    {
        static void Main()
        {
            int yourAge;            

            Console.Write("Please type in your age: ");
            yourAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: {0}", yourAge + 10);
                        
        }
    }
}
