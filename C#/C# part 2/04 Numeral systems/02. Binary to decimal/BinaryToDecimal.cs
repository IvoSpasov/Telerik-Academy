// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        bool check = false;
        int sum = 0;
        string binaryNumberCopy = null;

        Console.WriteLine("This program converts binary to decimal number.");
        Console.Write("Please enter the binary number: ");
        do
        {
            string binaryNumber = Console.ReadLine();
            binaryNumberCopy = binaryNumber;
            int[] binaryArray = new int[binaryNumber.Length];

            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryNumber[i] == '0' || binaryNumber[i] == '1')
                {
                    binaryArray[i] = int.Parse(binaryNumber[i].ToString());
                    check = false;
                }
                else
                {
                    Console.Write("Please eneter a valid binary number: ");
                    check = true;
                    sum = 0; // very important line :)
                    break;
                }
                sum += (binaryArray[i] * 2 << binaryArray.Length - i - 2);

            }
            sum += (binaryArray[binaryArray.Length - 1] * 1);

        }
        while (check);

        Console.WriteLine("The result is: " + sum);

        // Second (shorter) way
        Console.WriteLine("The result is: " + Convert.ToInt32(binaryNumberCopy, 2)); 
    }
}
