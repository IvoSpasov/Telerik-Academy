namespace _01.SelectionSorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 5, 2, 16, 65, 34, 94, 94, 23, 17, 84, 66 };
            var sorter = new SelectionSorter();
            sorter.Sort(numbers);
            Console.WriteLine(String.Join(", ", numbers));
        }

    }

    public class SelectionSorter
    {
        public void Sort(IList<int> arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }

            this.SelectionSort(arr);
        }

        private void SelectionSort(IList<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        min = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
