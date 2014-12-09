// Write a program that finds the index of given element in a sorted array of integers by using the binary 
// search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] myArray = { 1, 3, 4, 6, 8, 9, 11, 15, 16, 17, 20, 21, 25 };
        //int number = int.Parse(Console.ReadLine());
        int number = 6; // here you can change the element which index you're looking for, or use the line above and read it from the console.
        int startIndex = 0;
        int endIndex = myArray.Length - 1;
        int middleIndex = 0;

        while (true)
        {
            middleIndex = (startIndex / 2) + (endIndex / 2);

            if (myArray[middleIndex] == number) // Do we have a winner?
            {
                Console.WriteLine("The index of element \"{0}\" is: {1}", number, middleIndex);
                break;
            }
            else if (startIndex > endIndex) // In case the element we're looking for is not present.
            {
                Console.WriteLine("Element \"{0}\" is not present in the array.", number);
                break;
            }
            else if (myArray[middleIndex] > number) // If the element is smaller
            {
                endIndex = middleIndex - 1;             // update endIndx.
            }
            else if (myArray[middleIndex] < number) // If the element is bigger
            {
                startIndex = middleIndex + 1;           // update startIndex.
            }
        }
    }
}