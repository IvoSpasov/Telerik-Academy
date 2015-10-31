// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadcimalToDecimal
{
    static void Main()
    {
        int sum = 0;
        bool check = false;
        string hexNumberCopy = null;

        Console.WriteLine("This program converts hexadecimal to decimal number.");
        Console.Write("Please enter the hexadecimal number: ");

        do
        {
            string hexNumber = Console.ReadLine();
            hexNumberCopy = hexNumber;
            int[] hexArray = new int[hexNumber.Length];

            for (int i = 0; i < hexArray.Length; i++)
            {
                if ((hexNumber[i] >= '0' && hexNumber[i] <= '9') || (hexNumber[i] >= 'A' && hexNumber[i] <= 'F'))
                {
                    switch (hexNumber[i])
                    {
                        case 'A': hexArray[i] = 10; break;
                        case 'B': hexArray[i] = 11; break;
                        case 'C': hexArray[i] = 12; break;
                        case 'D': hexArray[i] = 13; break;
                        case 'E': hexArray[i] = 14; break;
                        case 'F': hexArray[i] = 15; break;
                        default: hexArray[i] = int.Parse(hexNumber[i].ToString()); break;
                    }
                    sum += (hexArray[i] * Convert.ToInt32(Math.Pow(16, hexArray.Length - i - 1)));
                    check = false;
                }
                else
                {
                    Console.Write("Please eneter a valid hexadecimal number: ");
                    check = true;
                    sum = 0; // very important line :)
                    break;
                }
            }
        } while (check);

        Console.WriteLine("The result is: " + sum);

        // Second (shorter) way
        Console.WriteLine("The result is: " + Convert.ToInt32(hexNumberCopy, 16));
    }
}