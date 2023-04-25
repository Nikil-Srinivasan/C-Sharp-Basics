namespace Exercise2.Bank
{
    public class LoanAccount : Accounts
    {
        public BankCustomer customer;
        public decimal loanAccountBalance { get; set; }
        private decimal interestRate = 2.5m;
        public LoanAccount(BankCustomer customer, decimal balance) : base(customer, balance) { }
        public override decimal calculateInterestRate(int period)
        {
            if (customer is IndividualCustomer && period > 3)
            {
                period -= 3;
            }
            else if (customer is CompanyCustomer && period > 2)
            {
                period -= 2;
            }
            return (loanAccountBalance * interestRate * period) / 100;
        }

        public override void depositMoney(decimal money)
        {
            loanAccountBalance += money;
            System.Console.WriteLine("\nMoney has been successfully deposited\n");
        }
    }
}

