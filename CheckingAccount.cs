namespace BankSystem
{
    public class CheckingAccount: BankAccount 
    {
        //fields 
        private decimal withDrawFee; 
        //properties 
        public decimal WithDrawFee
        {
            get { return withDrawFee; }
            set
            {
                if (value < 0)
                    Console.WriteLine("fee can NOT be less than zero");
                else
                    withDrawFee = value; 
            }
        }
        //constructor 
        public CheckingAccount(string accountNumber , decimal initialBalance ,decimal withDrawFee) :base(accountNumber , initialBalance)
        {
           WithDrawFee = withDrawFee;
        }
        //methods 
        public override void withDraw(decimal amount)
        {
            base.withDraw(amount + withDrawFee);
        }
    }
}
