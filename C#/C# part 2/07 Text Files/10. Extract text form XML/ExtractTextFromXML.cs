// Write a program that extracts from given XML file all the text without the tags. Example:
// <?xml version="1.0"><student><name>Pesho</name>
// <age>21</age><interests count="3"><interest>
// Games</instrest><interest>C#</instrest><interest>
// Java</instrest></interests></student>

using System;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\XML (input).txt");
            StreamWriter writer = new StreamWriter(@"..\..\Text (output).txt");

            using (reader)
            {
                using (writer)
                {
                    string XML = reader.ReadToEnd();
                    int indexStart = 0;
                    int indexEnd = 0;

                    while (indexEnd != -1)
                    {
                        indexStart = XML.IndexOf(">", indexStart + 1);
                        indexEnd = XML.IndexOf("<", indexStart);

                        if (indexStart + 1 != indexEnd && indexEnd != -1)
                        {
                            string text = string.Empty;
                            string text2 = string.Empty;
                            text = XML.Substring(indexStart + 1, indexEnd - indexStart - 1);

                            // I'm reading the whole document so this is how I get rid of the new lines in the output file.
                            if (text[0] == '\r' && text != "\r\n")
                            {
                                text2 = text.Substring(2, text.Length - 2);                      
                                writer.WriteLine(text2);
                            }

                            else if (text != "\r\n")
                            {
                                writer.WriteLine(text);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Extraction successful.");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: " + exc);
        }
    }
}
