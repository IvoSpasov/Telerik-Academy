// Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;
class WordsReplace
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
                        line = Regex.Replace(line, @"\bstart\b", "finish");
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