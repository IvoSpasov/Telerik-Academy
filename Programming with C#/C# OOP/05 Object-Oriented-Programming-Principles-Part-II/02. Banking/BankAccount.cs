namespace _02.Banking
{
    using System;

    public enum Customer
    {
        Person, Company
    }
    public abstract class BankAccount
    {
        private decimal interestRate;

        public Customer Customer { get; protected set; } // only inheritance classes can modify the balance
        public decimal Balance { get; protected set; } // only inheritance classes can modify the balance
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set // I don't know if you can change the interest so I'll leve it unprotected (public).
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest cannot be a negative number.");
                }

                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int period);
    }
}
