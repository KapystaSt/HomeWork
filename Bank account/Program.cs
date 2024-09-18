using System;

namespace Bank_account
{
    class Account
    {
        public string Name { get; }
        public double Balance { get; private set; }

        public Account(string name, double initialBalance)
        {
            Name = name;
            Balance = initialBalance >= 0 ? initialBalance : 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdrawal(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            heikkisAccount.Withdrawal(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);

            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);
        }
    }
}

