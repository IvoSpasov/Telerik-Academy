// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        string filePath = @"..\..\Life.txt";

        try
        {
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("Windows-1251"));
            string result = string.Empty;

            using (reader)
            {
                string line = reader.ReadLine();
                int lineCounter = 1;

                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        result += line + "\n";
                    }
                    line = reader.ReadLine();
                    lineCounter++;
                }
            }

            StreamWriter writer = new StreamWriter(filePath, false, Encoding.GetEncoding("Windows-1251"));

            using (writer)
            {
                writer.WriteLine(result);
            }

            Console.WriteLine("Deletion successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}", exc.Message);
        }
    }
}
