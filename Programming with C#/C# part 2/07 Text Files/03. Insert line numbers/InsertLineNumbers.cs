// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Life(input).txt", Encoding.GetEncoding("Windows-1251"));
            StreamWriter writer = new StreamWriter(@"..\..\Life(output).txt", false, Encoding.GetEncoding("Windows-1251"));

            using (reader)
            {
                string oneLine = reader.ReadLine();
                int lineNumber = 1;

                using (writer)
                {
                    while (oneLine != null)
                    {
                        oneLine = lineNumber + ". " + oneLine;
                        writer.WriteLine(oneLine);
                        lineNumber++;
                        oneLine = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Line number insertion successful.");

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}
