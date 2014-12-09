namespace Phone
{
    using System;

    public class Call
    {
        public Call()
        {
        }

        public Call(DateTime phoneCallStart)
        {
            this.CallStart = phoneCallStart;
        }

        public Call(DateTime phoneCallStart, DateTime phoneCallEnd)
            : this(phoneCallStart)
        {
            this.CallEnd = phoneCallEnd;
        }

        public Call(DateTime phoneCallStart, DateTime phoneCallEnd, string number)
            : this(phoneCallStart, phoneCallEnd)
        {
            this.PhoneNumber = number;
        }

        public DateTime CallStart { get; set; }
        public DateTime CallEnd { get; set; }
        public string PhoneNumber { get; set; }
        public double Duration
        {
            get { return (CallEnd - CallStart).TotalMinutes; } // I decided that I want the duration to be in minutes, because the price is per minute.
        }                                                      // But when I print it, it will be in the format (mm:ss)

        public override string ToString()
        {
            int minutes = (int)Duration;
            int seconds = (int)((Duration - minutes) * 60);
            string template = "Information about a call\nDate : {0}\nTime: {1}\nDialed phone number: {2}\nDuration: {3}:{4} (mm:ss)";
            string result = string.Format(template, CallStart.ToShortDateString(), CallStart.ToShortTimeString(),
                PhoneNumber ?? "the number is hidden", minutes, seconds);
            return result;
        }

    }
}
