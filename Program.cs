using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
                Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammoc");

            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");

            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}

            account.MakeDeposit(-300, DateTime.Now, "steeling");
        }
    }
}
