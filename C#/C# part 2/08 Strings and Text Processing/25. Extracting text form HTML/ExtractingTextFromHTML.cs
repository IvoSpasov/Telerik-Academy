// Write a program that extracts from given HTML file its title (if available), and its body
// text without the HTML tags. Example:
// <html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>

using System;
using System.Text;

class ExtractingTextFromHTML
{
    static void Main(string[] args)
    {
        string htmlDoc = "<html>\n" +
            "  <head><title>News</title></head>\n" +
            "  <body><p><a href=\"http://academy.telerik.com\">Telerik\n" +
            "    Academy</a>aims to provide free real-world practical\n" +
            "    training for young people who want to turn into\n" +
            "    skillful .NET software engineers.</p></body>\n" +
            "</html>";
        bool outsideTag = false;
        string[] lines = htmlDoc.Split('\n');
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim() + " ";
            for (int j = 0; j < lines[i].Length; j++)
            {
                if (lines[i][j] == '<')
                {
                    outsideTag = false;

                }
                else if (lines[i][j] == '>' && lines[i][j + 1] != '<' && lines[i][j + 1] != ' ')
                {
                    outsideTag = true;
                    result.Append(" ");
                }

                if (outsideTag && lines[i][j] != '>')
                {
                    result.Append(lines[i][j]);
                }
            }
        }

        Console.WriteLine("Before:");
        Console.WriteLine(htmlDoc);
        Console.WriteLine();
        Console.WriteLine("After:");
        Console.WriteLine(result.ToString().Trim());
    }
}
