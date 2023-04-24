namespace Exercise2.Bank
{
    public class DepositAccount : Bank
    {
        public decimal depositAccountBalance { get; set; }
        private decimal depositAccountInterestRate = 0;
        public DepositAccount(BankCustomer customer, decimal AccountBalance)
        {
            depositAccountBalance = AccountBalance;

            if (depositAccountBalance > 1000)
            {
                depositAccountInterestRate = 1.25m;
            }
        }
        public decimal calculateInterestRate(int period)
        {
            return (depositAccountBalance * depositAccountInterestRate * period) / 100;
        }

        public void depositMoney(decimal money)
        {
            depositAccountBalance += money;
            System.Console.WriteLine("Money has been successfully deposited");
        }

        public void withdrawMoneyFromDeposit(decimal money)
        {
            if (money < depositAccountBalance)
            {
                System.Console.WriteLine("Withdrawal is successfully done");
                depositAccountBalance -= money;
            }
            else
            {
                System.Console.WriteLine("Insufficient money");
            }
        }
    }
}

