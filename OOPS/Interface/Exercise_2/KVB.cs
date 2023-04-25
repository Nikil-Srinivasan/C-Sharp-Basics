using Spectre.Console;

namespace Exercise2.Bank
{
    public class KVB
    {
        public static char checkContinueOrNot()
        {
            System.Console.Write("\nWould you Like to continue? (Y/N): ");
            char continueOrNot = Convert.ToChar(Console.ReadLine());
            return continueOrNot;
        }

        public static void displayThankYou()
        {
            AnsiConsole.Write(new FigletText("Thank You").LeftJustified().Color(Color.DarkOrange));
            return;
        }
        public static void Main(string[] args)
        {
            AnsiConsole.Write(new FigletText("Bank Of Kovai.co").LeftJustified().Color(Color.DarkOrange));
            try
            {
                while (true)
                {
                start1:
                    System.Console.WriteLine("-----------------------");
                    Console.WriteLine("Choose type of customer");
                    System.Console.WriteLine("-----------------------");
                    System.Console.WriteLine("\n\n1) Individual Account\n2) Company Account\n");
                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                    System.Console.Write("Your Option: ");
                    int customerOption = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");

                    if (customerOption <= 0 || customerOption > 2)
                    {
                        System.Console.WriteLine("Wrong Choice");
                        char continueOrNot = checkContinueOrNot();
                        if (continueOrNot == 'Y' || continueOrNot == 'y') goto start1;
                        else displayThankYou();
                    }

                start2:
                    Console.WriteLine("\n\n-----------------");
                    Console.WriteLine("Choose an account");
                    Console.WriteLine("-----------------");
                    System.Console.WriteLine("\n\n1) Deposit Account\n2) Loan Account\n3) Mortgage Account\n");
                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                    System.Console.Write("Your Option: ");
                    int accountOption = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");

                    if (customerOption <= 0 || customerOption > 3)
                    {
                        System.Console.WriteLine("Wrong Choice");
                        char continueOrNot = checkContinueOrNot();
                        if (continueOrNot == 'Y' || continueOrNot == 'y') goto start2;
                        else displayThankYou();
                    }
                    System.Console.Write("Enter account holder name: ");
                    string customerName = Console.ReadLine();
                    System.Console.Write("Enter account holder age: ");
                    int customerAge = Convert.ToInt32(Console.ReadLine());

                    switch (customerOption)
                    {
                        case 1:
                            IndividualCustomer obj = new IndividualCustomer(customerName, customerAge);
                            switch (accountOption)
                            {
                                case 1:
                                    DepositAccount account1 = new DepositAccount(obj, 0);
                                startDeposit:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Withdraw Money\n5) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account1.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:

                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account1.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account1.depositAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            System.Console.WriteLine("Enter amount to be withdrawed");
                                            account1.withdrawMoneyFromDeposit(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot4 = checkContinueOrNot();
                                            if (continueOrNot4 == 'Y' || continueOrNot4 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 5:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }


                                    }
                                case 2:
                                    LoanAccount account2 = new LoanAccount(obj, 0);
                                startLoan:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm1 = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm1)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account2.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:
                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account2.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account2.loanAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                    }
                                case 3:
                                    MortgageAccount account3 = new MortgageAccount(obj, 0);
                                startMortgage:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm2 = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm2)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account3.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:
                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account3.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account3.mortgageAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                    }
                                default:
                                    System.Console.WriteLine("Oops! Wrong Choice");
                                    break;
                            }
                            break;

                        case 2:
                            CompanyCustomer obj1 = new CompanyCustomer(customerName, customerAge);
                            switch (accountOption)
                            {
                                case 1:
                                    DepositAccount account1 = new DepositAccount(obj1, 0);
                                startDeposit:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Withdraw Money\n5) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account1.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:
                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account1.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account1.depositAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            System.Console.WriteLine("Enter amount to be withdrawed");
                                            account1.withdrawMoneyFromDeposit(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot4 = checkContinueOrNot();
                                            if (continueOrNot4 == 'Y' || continueOrNot4 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 5:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startDeposit;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }

                                    }
                                case 2:
                                    LoanAccount account2 = new LoanAccount(obj1, 0);
                                startLoan:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm1 = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm1)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account2.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:
                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account2.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account2.loanAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startLoan;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                    }
                                case 3:
                                    MortgageAccount account3 = new MortgageAccount(obj1, 0);
                                startMortgage:
                                    Console.WriteLine("\n\nChoose any option :\n\n1) Deposit Money\n2) Check Interest Rate\n3) Check Balance\n4) Exit\n");
                                    System.Console.WriteLine("\n~~~~~~~~~~~~~~");
                                    System.Console.Write("Your Option: ");
                                    int atm2 = Convert.ToInt32(Console.ReadLine());
                                    System.Console.WriteLine("~~~~~~~~~~~~~~\n");
                                    switch (atm2)
                                    {
                                        case 1:
                                            System.Console.WriteLine("Enter amount to be deposited");
                                            account3.depositMoney(Convert.ToDecimal(Console.ReadLine()));
                                            char continueOrNot1 = checkContinueOrNot();
                                            if (continueOrNot1 == 'Y' || continueOrNot1 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 2:
                                            System.Console.Write("Enter the time period : ");
                                            decimal interest = account3.calculateInterestRate(Convert.ToInt32(Console.ReadLine()));
                                            System.Console.WriteLine("The interest rate is : " + interest);
                                            char continueOrNot2 = checkContinueOrNot();
                                            if (continueOrNot2 == 'Y' || continueOrNot2 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 3:
                                            System.Console.WriteLine("Your Account Balance: " + account3.mortgageAccountBalance);
                                            char continueOrNot3 = checkContinueOrNot();
                                            if (continueOrNot3 == 'Y' || continueOrNot3 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                        case 4:
                                            displayThankYou();
                                            return;
                                        default:
                                            System.Console.WriteLine("Oops! Wrong Choice");
                                            char continueOrNot5 = checkContinueOrNot();
                                            if (continueOrNot5 == 'Y' || continueOrNot5 == 'y') goto startMortgage;
                                            else
                                            {
                                                displayThankYou();
                                                return;
                                            }
                                    }
                                default:
                                    System.Console.WriteLine("Oops! Wrong Choice");
                                    break;
                            }
                            break;


                        default:
                            System.Console.WriteLine("Oops! Wrong Choice");
                            break;
                    }
                    char finalContinueOrNot = Convert.ToChar(Console.Read());
                    if (finalContinueOrNot == 'Y' || finalContinueOrNot == 'y') goto start1;
                    else break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("OOPS!!! Try Again...");
            }
        }
    }
}