namespace _02_IEnum_task
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static double Sum<T>(this IEnumerable<T> collection)
        {
            double sum = 0;

            foreach (var item in collection)
            {
                sum += Convert.ToDouble(item);
            }

            return sum;
        }

        public static double Product<T>(this IEnumerable<T> collection)
        {
            double product = 1;

            foreach (var item in collection)
            {
                product *= Convert.ToDouble(item);
            }

            return product;
        }

        public static double Min<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            double temp = double.MaxValue;

            foreach (var item in collection)
            {
                if (temp > Convert.ToDouble(item))
                {
                    temp = Convert.ToDouble(item);
                }
            }

            return temp;
        }

        public static double Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            double temp = double.MinValue;

            foreach (var item in collection)
            {
                if (temp < Convert.ToDouble(item))
                {
                    temp = Convert.ToDouble(item);
                }
            }

            return temp;
        }

        public static double Average<T>(this IEnumerable<T> collection)
        {
            double sum = 0;
            double count = 0;

            foreach (var item in collection)
            {
                sum += Convert.ToDouble(item);
                count++;
            }

            return sum / count;
        }
    }
}
