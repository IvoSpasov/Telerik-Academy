// * Write a program that shows the internal binary representation of given 32-bit signed floating-point number
// in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, 
// mantissa = 10110100000000000000000.

using System;

class FloatingPointNubersRepresentation
{
    static void Main()
    {
        float floatNumber = -27.25f;
        byte[] getDecimalValues = BitConverter.GetBytes(floatNumber);
        string eightDigits = string.Empty;
        byte[] resultArray = new byte[32];

        for (int i = 0, jump = 0; i < getDecimalValues.Length; i++, jump += 8)
        {
            eightDigits = Convert.ToString(getDecimalValues[i], 2);

            for (int j = 0; j < eightDigits.Length; j++)
            {
                resultArray[resultArray.Length - j - jump - 1] = byte.Parse(eightDigits[eightDigits.Length - j - 1].ToString());
            }
        }

        // Print out
        string sign = resultArray[0].ToString();
        string exponent = string.Empty;
        string mantissa = string.Empty;

        for (int i = 1; i < 9; i++)
        {
            exponent += resultArray[i];
        }
        for (int i = 9; i < resultArray.Length; i++)
        {
            mantissa += resultArray[i];
        }

        //string finalResult = string.Empty;
        //finalResult += string.Join("", resultArray);
        //Console.WriteLine(finalResult);

        Console.WriteLine("Sign -> " + sign);
        Console.WriteLine("Exponent -> " + exponent);
        Console.WriteLine("Mantissa -> " + mantissa);
    }
}
