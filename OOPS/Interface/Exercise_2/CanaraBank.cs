public class CanaraBank : IBank
{
    public void checkBalance()
    {
        Console.WriteLine("\nYou have Rs. 10 in your account\n");
    }

    public void creditMoney(int money)
    {
        Console.WriteLine("\n Rs.{0} Credited \n", money);
    }

    public void debitMoney(int money)
    {
        Console.WriteLine("\n Rs.{0} Debited \n", money);
    }
}