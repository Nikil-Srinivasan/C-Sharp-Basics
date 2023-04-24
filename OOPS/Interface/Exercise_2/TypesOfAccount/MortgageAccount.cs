namespace Exercise2.Bank
{
    public class MortgageAccount : Bank
    {
        public decimal mortgageAccountBalance { get; set; }
        private decimal interestRate = 0;
        public MortgageAccount(BankCustomer customer, decimal AccountBalance)
        {
            mortgageAccountBalance = AccountBalance;

            if (customer is IndividualCustomer)
            {
                interestRate = 2.75m;

            }
            else if (customer is CompanyCustomer)
            {
                interestRate = 3.23m;
            }
        }
        public decimal calculateInterestRate(int period)
        {
            if (interestRate == 2.75m && period > 6) period -= 6;
            else if (interestRate == 3.23m && period > 12) period -= 6;

            return (mortgageAccountBalance * interestRate * period) / 100;
        }

        public void depositMoney(decimal money)
        {
            mortgageAccountBalance += money;
            System.Console.WriteLine("Money has been successfully deposited");
        }
    }
}