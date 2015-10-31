namespace _02.Banking
{
    using System;

    public class LoanAccount : BankAccount, IDeposit
    {
        public LoanAccount(Customer typeOfCustomer, decimal interestRate)
        {
            base.Customer = typeOfCustomer;
            base.Balance = 0; // usually when you create new account there are no money in it.
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
            if (base.Customer == Customer.Person)
            {
                if (period <= 3)
                {
                    return 0;
                }
                else
                {
                    return (period - 3) * base.InterestRate;
                }
            }
            else if (base.Customer == Customer.Company)
            {
                if (period <= 2)
                {
                    return 0;
                }
                else
                {
                    return (period - 2) * base.InterestRate;
                }
            }
            else
            {
                throw new ArgumentException("There is no such customer. Customer must be \"Company\" or \"Person\".");
            }
        }

    }
}
