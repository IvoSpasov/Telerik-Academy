// Refactor the following code to apply variable usage and naming best practices:

namespace _02_VariableUsage
{
    using System;

    class MainProgram
    {
        public static void Main()
        {
            double[] numbers = { 1, 2, 3, 4, 5.5 };
            PrintStatistics(numbers);
        }

        public static void PrintStatistics(double[] numbers)
        {
            double maxValue = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            Console.WriteLine("The maximal value from the array is: " + maxValue);

            double minValue = double.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            Console.WriteLine("The minimal value from the array is: " + minValue);

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double averageValue = sum / numbers.Length;
            Console.WriteLine("The average value from the array is: " + averageValue);
        }
    }
}