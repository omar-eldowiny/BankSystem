namespace BankSystem
{
    public class SavingsAccount : BankAccount
    {
        //fields 
        private decimal interestRate; 
        //properties 
        public decimal InterestRate 
        {
            get { return interestRate; }
            set
            {
                if(value < 0)
                    Console.WriteLine("the interest can NOT be less than zero ! ");
                else if (value > 1)
                    Console.WriteLine("the interest can NOT be more than 100% !");
                else
                {
                    interestRate = value;
                    Console.WriteLine("your interest has been signed sucssfully !");
                }
            }
        }
        //constructor 
        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate) : base(accountNumber, initialBalance)
        {
          
            this.interestRate = interestRate;
        }
    }
}
