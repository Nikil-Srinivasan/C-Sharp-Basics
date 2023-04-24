public class BankCustomer
{
    public static void main()
    {
        Bank_A savingsAccount1 = new Bank_A();
        savingsAccount1.balance = 150.18M;
        Console.WriteLine("\nAccount Balance in Bank A : {0:C2}\n", savingsAccount1.getBalance());

        Bank_A savingsAccount2 = new Bank_A();
        savingsAccount2.balance = 89100.24M;
        Console.WriteLine("Account Baance in Bank B : {0:C2}\n", savingsAccount2.getBalance());

        Bank_A savingsAccount3 = new Bank_A();
        savingsAccount3.balance = 2345670.75M;
        Console.WriteLine("Account Balance in Bank C : {0:C2}\n", savingsAccount3.getBalance());
    }
}