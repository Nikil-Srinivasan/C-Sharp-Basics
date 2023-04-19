public class FederalBank : IBank
{
    public void checkBalance()
    {
        Console.WriteLine("\nYou have Rs. 1,00,00,000 in your account\n");
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