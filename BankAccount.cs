namespace BankSystem
{
    public class BankAccount
    {
        //fields 
        private decimal balance; 
        //properties
        public decimal Balance 
        {
            get { return balance; }
            protected set 
            {
                if (value < 0)
                    Console.WriteLine("Balance can not be less than zero");
                else
                    balance = value; 
            } 
        }
        protected string AccountNumber { get; private set; }
        
        //constuctor 
        public BankAccount(string accountNumber , decimal optionalBalance = 0 )
        {
            AccountNumber = accountNumber;
            balance = optionalBalance; 
        }
        //methods 
        public virtual void deposite(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("The Deposite Done Sussfully !");
                return;
            }
            else
                Console.WriteLine("Please Enter a Valid Amont !"); 
        }
        public virtual void withDraw(decimal amount)
        {
            if (amount <= 0)
                Console.WriteLine("Please Enter A Valid Amount");
            else if (amount > balance)
                Console.WriteLine("There is NOT Enough Balance !");
            else
            {
                balance -= amount;
                Console.WriteLine("The Transaction Done Sucssefully !");
            }

        }
             

    }
}
