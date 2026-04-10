using System;

namespace BankSystem
{
    public class CheckingAccount : BankAccount
    {
        // Fields
        private decimal _withdrawFee;

        // Properties
        public decimal WithdrawFee
        {
            get { return _withdrawFee; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Error: Fee cannot be less than zero.");
                else
                    _withdrawFee = value;
            }
        }

        // Constructor
        public CheckingAccount(string accountNumber, decimal initialBalance, decimal withdrawFee) 
            : base(accountNumber, initialBalance)
        {
            WithdrawFee = withdrawFee; // Using Property
        }

        // Methods
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"Attempting to withdraw {amount:C} with a fee of {WithdrawFee:C}...");
            // Pass the total amount (requested + fee) to the base class
            base.Withdraw(amount + WithdrawFee);
        }
    }
}
