public class Bank_C : Bank
{
    public decimal balance { get; set; }
    public override decimal getBalance()
    {
        return balance;
    }
}