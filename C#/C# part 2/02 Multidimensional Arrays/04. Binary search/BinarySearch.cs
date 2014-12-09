// Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
// and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter the lenght of the array (N): ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        Console.Write("Please eneter {0} numbers on the same line: ", n);
        string numbers = Console.ReadLine();
        string[] separators = { " ", ", ", "\t", " ,", "," };
        string[] separated = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < myArray.Length && i < separated.Length; i++)
        {
            myArray[i] = int.Parse(separated[i]);
        }
        //int[] myArray = { 5, 10, 15 };

        Console.Write("Please eneter the number you're looking for (K): ");
        int k = int.Parse(Console.ReadLine());
        
        Array.Sort(myArray);
        int index = Array.BinarySearch(myArray, k);
        
        if (index == -1)
        {
            Console.WriteLine("There is no such number.");
        }
        else if (index < 0)
        {
            index = ~index - 1;
            Console.WriteLine("The number is \"{0}\" at index \"{1}\"", myArray[index], index);
        }
        else
        {
            Console.WriteLine("The number is \"{0}\" at index \"{1}\"", myArray[index], index); 
        }
    }
}

