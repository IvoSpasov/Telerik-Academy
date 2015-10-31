using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Program
    {
        private static bool[,] input;
        private static long[] cache;

        static void Main()
        {
            long sumOfSalaries = 0;
            input = ReadInput();
            cache = new long[input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                sumOfSalaries += FindSalary(i);    
            }

            Console.WriteLine(sumOfSalaries);
        }

        private static long FindSalary(int employee)
        {
            if (cache[employee] > 0)
            {
                return cache[employee];
            }

            long currentSalary = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (input[employee, i])
                {
                    currentSalary += FindSalary(i);
                }
            }

            if (currentSalary == 0)
            {
                currentSalary = 1;
            }

            cache[employee] = currentSalary;

            return currentSalary;
        }

        private static bool[,] ReadInput()
        {
            int c = int.Parse(Console.ReadLine());
            bool[,] adjMarix = new bool[c, c];

            for (int i = 0; i < c; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < c; j++)
                {
                    adjMarix[i, j] = (line[j] == 'Y');
                }
            }

            return adjMarix;
        }
    }
}
