namespace Exercise2.Bank
{
    public class DepositAccount : Accounts
    {
        public decimal depositAccountBalance { get; set; }
        private decimal depositAccountInterestRate = 0;
        public DepositAccount(BankCustomer customer_obj, decimal balance) : base(customer_obj, balance) { }
        public override decimal calculateInterestRate(int period)
        {
            if (depositAccountBalance > 1000)
            {
                depositAccountInterestRate = 1.25m;
            }
            return (depositAccountBalance * depositAccountInterestRate * period) / 100;
        }

        public override void depositMoney(decimal money)
        {
            depositAccountBalance += money;
            System.Console.WriteLine("\nMoney has been successfully deposited\n");
        }

        public void withdrawMoneyFromDeposit(decimal money)
        {
            if (money <= depositAccountBalance)
            {
                System.Console.WriteLine("\nWithdrawal is successfully done");
                depositAccountBalance -= money;
            }
            else
            {
                System.Console.WriteLine("\nInsufficient money");
            }
        }
    }
}

