public class Customer
{
    public static void main()
    {
        FederalBank savingsAccount = new FederalBank();
        savingsAccount.checkBalance();
        savingsAccount.creditMoney(1000);
        savingsAccount.debitMoney(2000);

        CanaraBank currentAccount = new CanaraBank();
        currentAccount.checkBalance();
        currentAccount.creditMoney(450000);
        currentAccount.debitMoney(23432);
    }
}
