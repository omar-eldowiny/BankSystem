using System;

namespace BankSystem
{
    public class SavingsAccount : BankAccount
    {
        // Fields
        private decimal _interestRate;

        // Properties
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value < 0 || value > 1)
                    Console.WriteLine("Error: Interest rate must be between 0 and 1 (e.g., 0.05 for 5%).");
                else
                    _interestRate = value;
            }
        }

        // Constructor
        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate) 
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate; // Using Property
        }

        // Methods
        public void AddInterest()
        {
            // Calculate the interest amount
            decimal interestAmount = Balance * InterestRate;
            
            Console.WriteLine($"Adding {InterestRate * 100}% interest...");
            
            // Add it to the balance using the base class Deposit method
            Deposit(interestAmount);
        }
    }
}
