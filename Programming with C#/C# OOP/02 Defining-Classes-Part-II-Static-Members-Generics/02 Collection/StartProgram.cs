namespace Collection
{
    using System;
    using System.Collections.Generic;
    using _04_Attributes;

    [Version(2.3)]
    public class StartProgram
    {
        static void Main()
        {
            GenericList<int> tempList = new GenericList<int>();

            for (int i = 5; i < 20; i++)
            {
                tempList.Add(i);
            }

            Console.WriteLine(tempList);

            int a = tempList.Max<int>();
            int b = tempList.Min<int>();
            Console.WriteLine("Max value: " + a);
            Console.WriteLine("Min value: " + b);

            tempList.RemoveAt(5);
            Console.WriteLine(tempList);

            tempList[8] = 256;
            Console.WriteLine(tempList);

            tempList.Insert(3, 632);
            Console.WriteLine(tempList);

            Console.WriteLine("List capacity: " + tempList.Capacity);
            Console.WriteLine("List count: " + tempList.Count);
        }
    }
}
