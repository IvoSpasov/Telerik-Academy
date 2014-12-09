namespace _05_Delegate_task
{
    using System;
using System.Threading;

    public delegate void SampleDelegate(double timeInSeconds);

    public class Timer
    {
        public static void Delay(SampleDelegate delgate, double seconds)
        {
            int miliseconds = (int)(seconds * 1000);

            while (true)
            {
                delgate.Invoke(seconds);
                Thread.Sleep(miliseconds);
            }
        }
    }
}
