namespace BT_5
{
    class Account
    {
        private long accountnumber;
        private string name;
        private double balance;
        private const double rate = 0.035;

        

        public Account()
        {

        }

        public Account(long accountnumber, string name, double balance)
        {
            this.Accountnumber = accountnumber;
            this.Name = name;
            this.Balance = balance;
           
            
        }

        public Account(long accountnumber, string name)
        {
            this.Accountnumber = accountnumber;
            this.Name = name;

        }

        public long Accountnumber 
        { 
            get => accountnumber; 
            set => accountnumber = value; 
        }
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public double Balance 
        { 
            get => balance; 
            set => balance = value; 
        }


        //Deposit
        public bool deposit(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            else
            {
                Balance += amount;
                Console.WriteLine("\n{0} Deposited:  " + amount , Name);
                return true;
            }
        }

        //Withdraw
        public bool withdraw(double amount, double fee)
        {
            if ( amount + fee >= Balance)
            {
                return false;
            }
            else
            {
                Balance -= (amount + fee);
                Console.WriteLine("\n{0} Withdrawed : " + amount , Name);
                return true;
            }
        }

        //Phí tài khoản 3
        public void addInterest()
        {
            Console.WriteLine("Fee account 3 = " + (float)(Balance += Balance * rate));
        }


        //Transfer
        public bool transfer(ref Account account2, double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                account2.Balance += amount;
                Console.WriteLine(String.Format("{0} transfered {1} to {2}\n", Name, amount, account2.Name));
                return true;
            }
            else
            {
                Console.WriteLine("Can't transfer");
                return false;
            }
        }

        public void toString()
        {
            Console.WriteLine(string.Format("Accountnumber: {0}  Name: {1}  Balance:{2}  ", Accountnumber, Name, Balance));
        }
    }
}