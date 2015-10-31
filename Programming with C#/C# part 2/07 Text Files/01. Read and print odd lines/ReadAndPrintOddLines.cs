// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class ReadAndPrintOddLines
{
    static void Main()
    {
        string line = string.Empty;

        try
        {
            using (StreamReader reader = new StreamReader(@"..\..\Life.txt", Encoding.GetEncoding("Windows-1251")))
            {
                int lineCounter = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineCounter++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file to read from is missing.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

