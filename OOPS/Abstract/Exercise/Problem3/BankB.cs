public class Bank_B : Bank
{
    public decimal balance { get; set; }
    public override decimal getBalance()
    {
        return balance;
    }
}