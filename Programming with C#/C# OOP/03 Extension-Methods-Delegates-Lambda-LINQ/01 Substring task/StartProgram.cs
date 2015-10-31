// Task 1 -> Implement an extension method Substring(int index, int length) for the class StringBuilder that 
// returns new StringBuilder and has the same functionality as Substring in the class String.

namespace _01_Substring_task
{
    using System;
    using System.Text;

    public class StartProgram
    {
        public static void Main()
        {
            var text = new StringBuilder();
            text.Append("I have no idea what I'm doing :)");
            Console.WriteLine("Original text:");
            Console.WriteLine(text.ToString());

            // calling my extension methods
            var substring = text.Substring(2, 10);
            Console.WriteLine("Text after substring(0, 10):");
            Console.WriteLine(substring.ToString());

            var substringUpToEnd = text.Substring(15);
            Console.WriteLine("Text after substring(15)");
            Console.WriteLine(substringUpToEnd.ToString());
        }
    }
}
