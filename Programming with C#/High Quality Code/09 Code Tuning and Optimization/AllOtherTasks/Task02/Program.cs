// Write a program to compare the performance of add, subtract, increment, multiply, divide for int, long, float, double and decimal values.

namespace Task02
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main()
        {

            int intVariable = 1;
            long longVariable = 1;
            float floatVariable = 1;
            double doubleVariable = 1;
            decimal decimalVariable = 1;
            int count = 5000000;

            # region add
            Console.WriteLine("Compare the performance of \"add\" for:");

            Console.Write("int -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    intVariable += 5;
                }
            });

            Console.Write("long -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    longVariable += 5;
                }
            });

            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable += 5.5f;
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable += 5.5;
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable += 5.5m;
                }
            });
            #endregion

            Console.WriteLine();

            #region subtract
            Console.WriteLine("Compare the performance of \"subract\" for:");

            Console.Write("int -> ");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    intVariable -= 5;
                }
            });

            Console.Write("long -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    longVariable -= 5;
                }
            });

            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable -= 5.5f;
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable -= 5.5;
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable -= 5.5m;
                }
            });
            #endregion

            Console.WriteLine();

            #region increment
            Console.WriteLine("Compare the performance of \"increment\" for:");

            Console.Write("int -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    intVariable++;
                }
            });

            Console.Write("long -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    longVariable++;
                }
            });

            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable++;
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable++;
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable++;
                }
            });
            #endregion

            Console.WriteLine();

            #region multiply
            Console.WriteLine("Compare the performance of \"multiply\" for:");

            Console.Write("int -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    intVariable *= 1;
                }
            });

            Console.Write("long -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    longVariable *= 1;
                }
            });

            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable *= 1f;
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable *= 1;
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable *= 1m;
                }
            });
            #endregion

            Console.WriteLine();

            #region divide
            Console.WriteLine("Compare the performance of \"divide\" for:");

            Console.Write("int -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    intVariable /= 1;
                }
            });

            Console.Write("long -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    longVariable /= 1;
                }
            });

            Console.Write("float -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    floatVariable /= 1f;
                }
            });

            Console.Write("double -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    doubleVariable /= 1;
                }
            });

            Console.Write("decimal -> ".PadRight(11));
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    decimalVariable /= 1m;
                }
            });
            #endregion
        }
    }
}
