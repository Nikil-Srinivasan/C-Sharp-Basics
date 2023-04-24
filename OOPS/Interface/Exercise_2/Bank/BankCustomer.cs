namespace Exercise2.Bank
{
    public abstract class BankCustomer
    {
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }

        public BankCustomer(string customerName, int customerAge)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
        }
    }
}
