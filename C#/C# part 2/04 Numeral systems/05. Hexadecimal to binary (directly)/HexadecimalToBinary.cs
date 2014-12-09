// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        string hexNumberCopy = null;
        string result = "";
        bool check = false;

        Console.WriteLine("This program converts hexadecimal numbers to binary numbers.");
        Console.Write("Please enter a hexadecimal number: ");

        do
        {
            string hexNumber = Console.ReadLine();
            hexNumberCopy = hexNumber;
            string[] hexArray = new string[hexNumber.Length];

            for (int i = 0; i < hexArray.Length; i++)
            {
                check = false;
                switch (hexNumber[i])
                {
                    case '0': hexArray[i] = "0000"; break;
                    case '1': hexArray[i] = "0001"; break;
                    case '2': hexArray[i] = "0010"; break;
                    case '3': hexArray[i] = "0011"; break;
                    case '4': hexArray[i] = "0100"; break;
                    case '5': hexArray[i] = "0101"; break;
                    case '6': hexArray[i] = "0110"; break;
                    case '7': hexArray[i] = "0111"; break;
                    case '8': hexArray[i] = "1000"; break;
                    case '9': hexArray[i] = "1001"; break;
                    case 'A': hexArray[i] = "1010"; break;
                    case 'B': hexArray[i] = "1011"; break;
                    case 'C': hexArray[i] = "1100"; break;
                    case 'D': hexArray[i] = "1101"; break;
                    case 'E': hexArray[i] = "1110"; break;
                    case 'F': hexArray[i] = "1111"; break;
                    default:
                        Console.Write("Please eneter a valid hexadecimal number: ");
                        check = true;
                        break;
                }
                if (check)
                {
                    break;
                }
            }
            result = string.Join("", hexArray);

        } while (check);

        Console.WriteLine("The result is: " + result);

        // Second (shorter but not direct) way.
        Console.WriteLine("The result is: " + Convert.ToString(Convert.ToInt32(hexNumberCopy, 16), 2));
    }
}
