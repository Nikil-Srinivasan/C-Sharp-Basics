namespace Exercise2.Bank
{
    public interface Bank
    {
        public decimal calculateInterestRate(int period);

        public void depositMoney(decimal money);

    }
}
