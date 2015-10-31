// Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.

namespace Task03
{
    using System;
    using System.Diagnostics;

    class Program
    {        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        static void Main()
        {
            float floatVariable;
            double doubleVariable;
            decimal decimalVariable;
            int count = 5000000;

            #region square root
            Console.WriteLine("Compare the performance of \"square root\" for:");
            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable = (float)Math.Sqrt(25);
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable = Math.Sqrt(25);
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable = (decimal)Math.Sqrt(25);
                }
            });
            #endregion

            #region natural logarithm
            Console.WriteLine("Compare the performance of \"natural logarithm\" for:");
            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable = (float)Math.Log(10);
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable = Math.Log(10);
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable = (decimal)Math.Log(10);
                }
            });
            #endregion

            #region natural logarithm
            Console.WriteLine("Compare the performance of \"natural logarithm\" for:");
            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable = (float)Math.Sin(2 * Math.PI);
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable = Math.Sin(2 * Math.PI);
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable = (decimal)Math.Sin(2 * Math.PI);
                }
            });
            #endregion
        }
    }
}


// The overall conclusion from both tasks is that the operations with decimal take more time.