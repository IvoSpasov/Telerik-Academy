// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
// and stores it the current directory. Find in Google how to download files in C#. 
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.Text;

class DownloadAFile
{
    static void Main()
    {
        WebClient client = new WebClient();
        string fileAddress = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = "../../Logo.jpg";

        try
        {
            using (client)
            {
                client.DownloadFile(fileAddress, fileName);
            }
            Console.WriteLine("Downloading successful.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid URL or the file does not exsist.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}

