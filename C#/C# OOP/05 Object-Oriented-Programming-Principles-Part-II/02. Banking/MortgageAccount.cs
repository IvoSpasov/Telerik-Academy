namespace _02.Banking
{
    using System;

    class MortgageAccount : BankAccount, IDeposit
    {
        public MortgageAccount(Customer typeOfCustomer, decimal interestRate)
        {
            base.Customer = typeOfCustomer;
            base.Balance = 0;
            base.InterestRate = interestRate;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("The value for amount cannot be negative.");
            }

            base.Balance += amount;
        }

        public override decimal CalculateInterest(int period)
        {
            if (base.Customer == Customer.Company)
            {
                if (period <= 12)
                {
                    return base.InterestRate * period * 0.5M;
                }
                else
                {
                    return (base.InterestRate * 12 * 0.5M) + (base.InterestRate * (period - 12));
                }
            }
            else if (base.Customer == Customer.Person)
            {
                if (period <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.InterestRate * (period - 6);
                }
            }
            else
            {
                throw new ArgumentException("There is no such customer. Customer must be \"Company\" or \"Person\".");
            }
        }
    }
}
