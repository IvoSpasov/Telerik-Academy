namespace _02_VariableUsage
{
    using System;

    public class ProgramStart
    {
        public static void Main()
        {
            double[] numbers = { 1, 2, 3, 4, 5.5 };
            PrintStatistics(numbers);
        }

        public static void PrintStatistics(double[] numbers)
        {
            double maxValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            Console.WriteLine("The maximal value from the array is: " + maxValue);

            double minValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
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