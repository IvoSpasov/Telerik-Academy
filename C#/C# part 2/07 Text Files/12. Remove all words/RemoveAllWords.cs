using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class RemoveAllWords
{
    static void Main()
    {
        string line = string.Empty;
        List<string> words = new List<string>();

        try
        {
            using (StreamReader input = new StreamReader("../../List of words.txt"))
            {
                while ((line = input.ReadLine()) != null)
                {
                    words.Add(line.ToLower());
                }
            }
            using (StreamReader input = new StreamReader("../../Life (input).txt", Encoding.GetEncoding("Windows-1251")))
            {
                using (StreamWriter output = new StreamWriter("../../Life (output).txt", false, Encoding.GetEncoding("Windows-1251")))
                {
                    while ((line = input.ReadLine()) != null)
                    {
                        line = line.ToLower();

                        for (int i = 0; i < words.Count; i++)
                        {
                            line = line.Replace(words[i], "");
                        }
                        output.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Deletion of words successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc.Message);
        }
    }
}

