public class Bank_A : Bank
{
    public decimal balance { get; set; }
    public override decimal getBalance()
    {
        return balance;
    }
}