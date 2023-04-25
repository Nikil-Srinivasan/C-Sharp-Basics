namespace Exercise2.Bank
{
    public abstract class Accounts : Bank
    {

        public BankCustomer customer_obj;
        public decimal balance;
        public abstract decimal calculateInterestRate(int period);

        public abstract void depositMoney(decimal money);

        public Accounts(BankCustomer customer_obj, decimal balance)
        {
            this.balance = balance;
            this.customer_obj = customer_obj;
        }
    }
}