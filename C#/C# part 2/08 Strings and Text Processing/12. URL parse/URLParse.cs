// Write a program that parses an URL address given in the format:
// [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
// [protocol] = "http"
// [server] = "www.devbg.org"
// [resource] = "/forum/index.php"

using System;
using System.Text;

class URLParse
{
    static void URLExtraction(string address)
    {
        string protocol = string.Empty;
        int protocolEnd = address.IndexOf("://");
        if (protocolEnd != -1)
        {
            protocol = address.Substring(0, protocolEnd);
        }

        int serverStart = address.IndexOf("://") + 3;
        if (serverStart == 2)
        {
            serverStart = 0;
        }
        int serverEnd = address.IndexOf('/', serverStart);
        if (serverEnd == -1)
        {
            serverEnd = address.Length;
        }
        string server = address.Substring(serverStart, serverEnd - serverStart);
        string resource = address.Substring(serverEnd);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resourse] = " + resource);
    }

    static void Main()
    {
        string address = "http://www.devbg.org/forum/index.php ";
        string address2 = "https://www.facebook.com/photo.php?fbid=509933499119386&set=a.411649345614469.1073741849.394475013998569&type=1&theater";
        string address3 = "en.wikipedia.org/wiki/List_of_Unicode_characters";
        string address4 = "en.wikipedia.org";
        URLExtraction(address);
        Console.WriteLine();
        URLExtraction(address2);
        Console.WriteLine();
        URLExtraction(address3);
        Console.WriteLine();
        URLExtraction(address4);
        Console.WriteLine();
    }
}