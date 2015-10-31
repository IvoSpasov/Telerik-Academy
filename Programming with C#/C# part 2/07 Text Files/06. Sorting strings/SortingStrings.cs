// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;

class SortingStrings
{
    static void Main()
    {
        try
        {
            List<string> names = new List<string>();
            StreamReader reader = new StreamReader(@"..\..\Names (input).txt");
            StreamWriter writer = new StreamWriter(@"..\..\Sorted names (output).txt");

            using (reader)
            {
                string name = reader.ReadLine();
                while (name != null)
                {
                    if (name != "")
                    {
                        names.Add(name);
                    }
                    name = reader.ReadLine();
                }
            }

            names.Sort();

            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }

            Console.WriteLine("Sorting successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}

