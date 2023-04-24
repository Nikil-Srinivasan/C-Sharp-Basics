namespace Exercise2.Bank
{
    public class LoanAccount : Bank
    {
        public decimal loanAccountBalance { get; set; }
        private decimal interestRate = 0;
        public LoanAccount(BankCustomer customer, decimal AccountBalance)
        {
            loanAccountBalance = AccountBalance;

            if (customer is IndividualCustomer)
            {
                interestRate = 2.5m;
            }
            else if (customer is CompanyCustomer)
            {
                interestRate = 3.1m;
            }
        }
        public decimal calculateInterestRate(int period)
        {
            if (interestRate == 2.5m && period > 3) period -= 3;
            else if (interestRate == 3.1m && period > 2) period -= 2;

            return (loanAccountBalance * interestRate * period) / 100;
        }

        public void depositMoney(decimal money)
        {
            loanAccountBalance += money;
            System.Console.WriteLine("Money has been successfully deposited");
        }
    }
}

