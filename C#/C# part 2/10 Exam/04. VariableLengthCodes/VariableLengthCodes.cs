namespace _04.VariableLengthCodes
{
    using System;
    using System.Text;

    class VariableLengthCodes
    {
        static void Main()
        {
            string firstLine = Console.ReadLine();
            string[] sequenceOfIntegersAsEncodedText = firstLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            char[] codeTable = ReadCodeTable();
            string binaryCode = DecodeFromIntToBinary(sequenceOfIntegersAsEncodedText);
            string decodedText = Decode(codeTable, binaryCode);
            Console.WriteLine(decodedText);
        }

        static char[] ReadCodeTable()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            char[] codeTable = new char[numberOfLines + 1];
            string currentRow;
            char currentSymbol;
            int currentSymbolBitsCount;

            for (int i = 0; i < numberOfLines; i++)
            {
                currentRow = Console.ReadLine();
                currentSymbol = currentRow[0];
                currentSymbolBitsCount = int.Parse(currentRow.Substring(1));
                codeTable[currentSymbolBitsCount] = currentSymbol;
            }

            return codeTable;
        }

        static string DecodeFromIntToBinary(string[] sequenceOfIntegers)
        {
            StringBuilder fullBinaryCode = new StringBuilder();
            int currentInteger;
            string currentBinaryNumber;
            string fullCurrentBinaryNumber;

            for (int i = 0; i < sequenceOfIntegers.Length; i++)
            {
                currentInteger = int.Parse(sequenceOfIntegers[i]);
                currentBinaryNumber = Convert.ToString(currentInteger, 2);
                fullCurrentBinaryNumber = AddMissingZerosAtTheBeggining(currentBinaryNumber);
                fullBinaryCode.Append(fullCurrentBinaryNumber);
            }

            string finalBinaryCode = RemoveZerosAtTheEnd(fullBinaryCode);
            return finalBinaryCode;
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

        static string Decode(char[] codeTable, string binaryCode)
        {
            int counter = 0;
            StringBuilder decodedText = new StringBuilder();

            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    counter++;
                }
                if (binaryCode[i] == '0' || i == binaryCode.Length - 1)
                {
                    decodedText.Append(codeTable[counter]);
                    counter = 0;
                }
            }

            return decodedText.ToString();
        }
    }
}
