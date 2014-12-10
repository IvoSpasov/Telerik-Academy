namespace _02.QuickSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            var numbers = new List<int>() { 5, 2, 16, 65, 34, 94, 94, 23, 17, 84, 66 };
            var sorter = new QuickSorter();
            numbers = sorter.Sort(numbers);
            Console.WriteLine(String.Join(", ", numbers));
        }
    }

    class QuickSorter
    {
        internal List<int> Sort(List<int> arr)
        {
            return QuickSort(arr);
        }

        private List<int> QuickSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            int pivotIndex = GetPivot(arr);
            int pivotValue = arr[pivotIndex];
            var less = new List<int>();
            var greater = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < pivotValue)
                {
                    less.Add(arr[i]);
                }
                else if (pivotIndex != i)
                {
                    greater.Add(arr[i]);
                }
            }

            less = QuickSort(less);
            greater = QuickSort(greater);

            less.Add(pivotValue);
            less.AddRange(greater);
            return less;
        }

        private int GetPivot(List<int> arr)
        {
            int pivotIndex = (arr.Count - 1) / 2;
            return pivotIndex;
        }
    }
}
