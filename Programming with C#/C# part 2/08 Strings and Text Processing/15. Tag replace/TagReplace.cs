// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with
// corresponding tags [URL=…]…/URL]. Sample HTML fragment:
// <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
// Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

// <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
// Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text;

class TagReplace
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik." +
            "com\">our site</a> to choose a training course. Also "
            + "visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        StringBuilder copy = new StringBuilder();
        copy.Append(text);
        copy.Replace("<a href=\"", "[URL=");
        copy.Replace("\">", "]");
        copy.Replace("</a>", "[/URL]");

        Console.WriteLine("Before:");
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("After:");
        Console.WriteLine(copy.ToString());
    }
}
