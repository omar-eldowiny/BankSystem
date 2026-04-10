using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bank Account System ===");
            
            // 1. Test Standard Bank Account
            Console.WriteLine("\n--- Standard Account ---");
            BankAccount standardAcc = new BankAccount("ACC-1001", 1000);
            standardAcc.Deposit(500);
            standardAcc.Withdraw(200);
            standardAcc.Withdraw(5000); // Should fail

            // 2. Test Checking Account
            Console.WriteLine("\n--- Checking Account ---");
            CheckingAccount checkingAcc = new CheckingAccount("CHK-2002", 2000, 15);
            checkingAcc.Withdraw(500); // Will deduct 515

            // 3. Test Savings Account
            Console.WriteLine("\n--- Savings Account ---");
            SavingsAccount savingsAcc = new SavingsAccount("SAV-3003", 5000, 0.05m); // 5% interest
            savingsAcc.AddInterest();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
