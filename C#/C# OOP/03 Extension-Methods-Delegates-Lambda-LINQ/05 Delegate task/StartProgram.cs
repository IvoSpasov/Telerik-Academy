// Task 7 -> Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _05_Delegate_task
{
    using System;

    public class StartProgram
    {
        public static void SampleMethod(double seconds)
        {
            Console.WriteLine("This method executes every {0} second/s.", seconds);
        }

        public static void Main()
        {
            // creating an instance of "SameDelegate" called "myOnlyDelegate" and assign it with my only method - "SampleMethod".
            SampleDelegate myOnlyDelegate = SampleMethod;

            // Calling the method "Delay" in class "Timer" which takes as arguments an instance of delegate and time in seconds(double).
            // The method "Delay" invokes the method or methods assinged to the instance of the delegate and delays it's or 
            // theirs execution with the specified number of seconds.
            double time = 1.5;
            Timer.Delay(myOnlyDelegate, time);
        }
    }
}
