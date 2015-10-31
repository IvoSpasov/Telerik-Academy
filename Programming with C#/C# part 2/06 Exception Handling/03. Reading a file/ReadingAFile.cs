// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadingAFile
{
    static void Main()
    {
        try
        {
            string filePath = @"C:\Windows\win.ini";
            Console.WriteLine(File.ReadAllText(filePath));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid file path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The file path is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory is not found.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is missing.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the file is denied. The problems could be:");
            Console.WriteLine(" - the file is read-only.");
            Console.WriteLine(" - the operation is not supported on the current platform.");
            Console.WriteLine(" - the path specified a directory.");
            Console.WriteLine(" - the caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in an invalid format.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Security error occurred. The caller does not have the required permission.");
        }
    }
}
