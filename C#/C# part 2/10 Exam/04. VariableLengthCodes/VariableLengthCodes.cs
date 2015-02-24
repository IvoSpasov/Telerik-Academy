using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableLengthCodes
{
    class VariableLengthCodes
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string[] sequenceOfIntegersAsEncodedText = firstLine.Split(' ');
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] codeTable = new string[numberOfLines];

            for (int i = 0; i < codeTable.Length; i++)
            {
                codeTable[i] = Console.ReadLine();
            }

            StringBuilder fullBinaryCode = new StringBuilder();
            int currentInteger;
            string currentBinaryNumber;
            string fullCurrentBinaryNumber;

            for (int i = 0; i < sequenceOfIntegersAsEncodedText.Length; i++)
            {
                currentInteger = int.Parse(sequenceOfIntegersAsEncodedText[i]);
                currentBinaryNumber = Convert.ToString(currentInteger, 2);
                fullCurrentBinaryNumber = AddMissingZerosAtTheBeggining(currentBinaryNumber);
                fullBinaryCode.Append(fullCurrentBinaryNumber);
            }

            string finalBinaryCode = RemoveZerosAtTheEnd(fullBinaryCode);
        }

        static string RemoveZerosAtTheEnd(StringBuilder binaryCode)
        {
            while (binaryCode[binaryCode.Length - 1] == '0')
            {
                binaryCode.Remove(binaryCode.Length - 1, 1);
            }

            return binaryCode.ToString();
        }

        static string AddMissingZerosAtTheBeggining(string binaryNumber)
        {
            if (binaryNumber.Length == 8)
            {
                return binaryNumber;
            }

            StringBuilder result = new StringBuilder(binaryNumber);

            while (result.Length != 8)
            {
                result.Insert(0, "0");
            }

            return result.ToString();
        }
    }
}
