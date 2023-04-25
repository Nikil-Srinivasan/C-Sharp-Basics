namespace Exercise2.Bank
{
    public class MortgageAccount : Accounts
    {
        public BankCustomer customer;
        public decimal mortgageAccountBalance { get; set; }
        private decimal interestRate = 3.2m;
        public MortgageAccount(BankCustomer customer, decimal balance) : base(customer, balance) { }
        public override decimal calculateInterestRate(int period)
        {
            if (customer is IndividualCustomer && period > 6)
            {
                period -= 6;

            }
            else if (customer is CompanyCustomer && period > 12)
            {
                period -= 6;
            }

            return (mortgageAccountBalance * interestRate * period) / 100;
        }

        public override void depositMoney(decimal money)
        {
            mortgageAccountBalance += money;
            System.Console.WriteLine("\nMoney has been successfully deposited\n");
        }
    }
}