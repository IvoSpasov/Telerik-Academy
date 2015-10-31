// Write a program that concatenates two text files into another text file

using System;
using System.Text;
using System.IO;

class ConcatenateTwoTextFiles
{
    static void Main()
    {
        string inputFilePath1 = @"..\..\Text file 1.txt";
        string inputFilePath2 = @"..\..\Text file 2.txt";
        string outputFilePath = @"..\..\Life.txt";

        try
        {
            StreamReader reader1 = new StreamReader(inputFilePath1, Encoding.GetEncoding("Windows-1251"));
            StreamReader reader2 = new StreamReader(inputFilePath2, Encoding.GetEncoding("Windows-1251"));
            StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.GetEncoding("Windows-1251"));

            string inputFile1 = string.Empty;
            string inputFile2 = string.Empty;
            string outputFile = string.Empty;

            using (reader1)
            {
                inputFile1 = reader1.ReadToEnd();
            }
            using (reader2)
            {
                inputFile2 = reader2.ReadToEnd();
            }
            using (writer)
            {
                outputFile = inputFile1 + "\n" + inputFile2;
                writer.Write(outputFile);
            }
            Console.WriteLine("Concatenation successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}", exc.Message);
        }
    }
}