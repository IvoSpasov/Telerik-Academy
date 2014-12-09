namespace _02.Banking
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            BankAccount[] differentAccounts = new BankAccount[] 
            {
                new DepositAccount(Customer.Person, 3.5M),
                new LoanAccount(Customer.Company, 5.2M),
                new MortgageAccount(Customer.Company, 4.3M),
            };

            foreach (var account in differentAccounts)
            {
                decimal result = account.CalculateInterest(8);
                System.Console.WriteLine(result);
            }

            Console.WriteLine(new string('-', 40));
            DepositAccount dep = new DepositAccount(Customer.Company, 2.2M);
            dep.Deposit(3000);
            Console.WriteLine("Balance after deposit: " + dep.Balance);
            // dep.Balance = 250; // Inaccessible due to access level "protected".
            dep.Withdraw(1000);
            Console.WriteLine("Balance after withdraw: " + dep.Balance);
            Console.WriteLine("Interest for 6 months: " + dep.CalculateInterest(6));
        }
    }
}
