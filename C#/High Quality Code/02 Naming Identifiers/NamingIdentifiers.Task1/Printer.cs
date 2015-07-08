namespace NamingIdentifiers.Task1
{
    using System;

    public class Printer
    {
        public void PrintOnConsole(bool variable)
        {
            string variableAsString = variable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}