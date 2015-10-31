namespace _03.Exceptions_task
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public T StartRange { get; private set; }
        public T EndRange { get; private set; }

        public InvalidRangeException(string msg, T startRange, T endRange)
            : base(msg)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public InvalidRangeException(string msg, Exception innerEx, T startRange, T endRange)
            : base(msg, innerEx)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public override string Message
        {
            get
            {
                return base.Message + " " + string.Format("Range is between {0} and {1}.", this.StartRange, this.EndRange);
            }
        }
    }
}
