using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteThePrefix
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Text (input).txt");
            StreamWriter writer = new StreamWriter(@"..\..\Text (output).txt");

            string line = string.Empty;
            int indexStart = 0;
            int indexEnd = 0;

            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();

                    while (line != null)
                    {
                        indexStart = line.IndexOf("test");
                        indexEnd = indexStart + 3;

                        if ((line[indexStart - 1] == ' ') && (line[indexEnd + 1] != ' '))
                        {
                            line = Regex.Replace(line, "test", "");
                            writer.WriteLine(line);
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Deletion successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc);
        }
    }
}
