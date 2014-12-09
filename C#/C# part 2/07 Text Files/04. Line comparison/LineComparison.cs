// Write a program that compares two text files line by line and prints the number of lines that are
// the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;

class LineComparison
{
    static void Main()
    {
        try
        {
            StreamReader reader1 = new StreamReader(@"..\..\Text file 1.txt", Encoding.GetEncoding("Windows-1251"));
            StreamReader reader2 = new StreamReader(@"..\..\Text file 2.txt", Encoding.GetEncoding("Windows-1251"));
            string inputFileLine1 = string.Empty;
            string inputFileLine2 = string.Empty;
            int countEqualLines = 0;
            int totalLines = 0;

            using (reader1)
            {
                using (reader2)
                {
                    inputFileLine1 = reader1.ReadLine();
                    inputFileLine2 = reader2.ReadLine();

                    while (inputFileLine1 != null || inputFileLine2 != null)
                    {
                        if (inputFileLine1 == inputFileLine2)
                        {
                            countEqualLines++;
                        }
                        totalLines++;
                        inputFileLine1 = reader1.ReadLine();
                        inputFileLine2 = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("There are {0} equal lines and {1} lines which are not equal.", countEqualLines, totalLines - countEqualLines);

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}
