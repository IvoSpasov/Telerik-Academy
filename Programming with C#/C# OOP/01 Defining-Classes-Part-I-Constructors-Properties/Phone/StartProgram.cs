namespace Phone
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            GSMTest.Test();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.Test();
        }
    }
}
