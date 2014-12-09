// Task 1 -> Implement an extension method Substring(int index, int length) for the class StringBuilder that 
// returns new StringBuilder and has the same functionality as Substring in the class String.

namespace _01_Substring_task
{
    using System;
    using System.Text;

    public class StartProgram
    {
        static void Main()
        {
            var text = new StringBuilder();
            text.Append("I have no idea what I'm doing :)");
            Console.WriteLine("Before:");
            Console.WriteLine(text.ToString());

            // calling my extension method
            text = text.Substring(0, 10);
            Console.WriteLine("After:");
            Console.WriteLine(text.ToString());
        }
    }
}
