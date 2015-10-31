namespace _02.Banking
{
    using System;

    public class DepositAccount : BankAccount, IDeposit, IWithdraw
    {
        public DepositAccount(Customer typeOfCustomer, decimal interestRate)
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

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("The value for amount cannot be negative.");
            }
            else if (amount > base.Balance)
            {
                throw new ArgumentException("The amount you have specifed is greater than the balance.");
            }

            base.Balance -= amount;
        }

        public override decimal CalculateInterest(int period)
        {
            if (0 <= base.Balance && base.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return base.InterestRate * period;
            }
        }
    }
}
