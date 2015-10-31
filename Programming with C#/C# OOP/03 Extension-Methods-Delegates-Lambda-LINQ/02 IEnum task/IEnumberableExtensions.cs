namespace _02_IEnum_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumberableExtensions
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
            double initialValue = Convert.ToDouble(collection.First());

            foreach (var item in collection)
            {
                if (initialValue > Convert.ToDouble(item))
                {
                    initialValue = Convert.ToDouble(item);
                }
            }

            return initialValue;
        }

        public static double Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            double initialValue = Convert.ToDouble(collection.First());

            foreach (var item in collection)
            {
                if (initialValue < Convert.ToDouble(item))
                {
                    initialValue = Convert.ToDouble(item);
                }
            }

            return initialValue;
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
