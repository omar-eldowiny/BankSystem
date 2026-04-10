using System;

namespace BankSystem
{
    public class BankAccount
    {
        // Private Fields 
        private decimal _balance;

        // Properties
        public decimal Balance
        {
            get { return _balance; }
            protected set
            {
                if (value < 0)
                    Console.WriteLine("Error: Balance cannot be less than zero.");
                else
                    _balance = value;
            }
        }

        public string AccountNumber { get; private set; }

        // Constructor
        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance; // Using Property for validation
        }

        // Methods
        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid deposit amount!");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Please enter a valid withdrawal amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Error: Insufficient balance!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C}. Remaining Balance: {Balance:C}");
            }
        }
    }
}
