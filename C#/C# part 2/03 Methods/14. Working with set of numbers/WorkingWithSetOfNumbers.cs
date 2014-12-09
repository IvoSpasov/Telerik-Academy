// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
// Use variable number of arguments.


using System;

class WorkingWithSetOfNumbers
{
    static int MinimalElement(params int[] elements)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] < minValue)
            {
                minValue = elements[i];
            }
        }

        return minValue;
    }
    static int MaximalElement(params int[] elements)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > maxValue)
            {
                maxValue = elements[i];
            }
        }

        return maxValue;
    }
    static double AverageOfElements(params int[] elements)
    {
        double sum = 0;
        double average = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }

        average = sum / elements.Length;
        return average;
    }
    static long SumOfElements(params int[] elements)
    {
        long sum = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }

        return sum;
    }
    static int ProductOfElements(params int[] elements)
    {
        int product = 1;

        for (int i = 0; i < elements.Length; i++)
        {
            product *= elements[i];
        }

        return product;
    }

    static void Main()
    {
        double result = 0;
        result = MinimalElement(6, -56, 93, 25, 305, 120);
        Console.WriteLine("The minimal element is: " + result);
        result = MaximalElement(6, -56, 93, 25, 305, 120);
        Console.WriteLine("The maximal element is: " + result);
        result = AverageOfElements(6, -56, 93, 25, 305, 120);
        Console.WriteLine("The average of the elements is: {0:F3}", result);
        result = SumOfElements(6, -56, 93, 25, 305, 120);
        Console.WriteLine("The sum of the elements is: " + result);
        result = ProductOfElements(6, -56, 93, 25, 305, 120);
        Console.WriteLine("The product of the elements is: " + result);
    }
}
