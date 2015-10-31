// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class SubstringReplace
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Input.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Output.txt");

            string line = string.Empty;

            using (reader)
            {
                using (writer)
                {
                   while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Replace("start", "finish");
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Replacing successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}
