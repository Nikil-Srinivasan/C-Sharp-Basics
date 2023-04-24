public class DriverClass
{
    public static void main()
    {
        Console.WriteLine("ChooseStall Type\n1)Gold Stall\n2)Premium Stall\n3)Executive Stall");
        int choiceOfStall = Convert.ToInt32(Console.ReadLine());
        switch (choiceOfStall)
        {
            case 1:
                Console.WriteLine("Enter Stall details in comma separated(Stall Name, Stall Cost, Owner Name, Number of TV sets)");
                string inputForGoldStall = Console.ReadLine();
                string[] goldStallInputs = inputForGoldStall.Split(",");
                GoldStall manager1 = new GoldStall(goldStallInputs[0], Convert.ToInt32(goldStallInputs[1]), goldStallInputs[2], Convert.ToInt32(goldStallInputs[3]));
                manager1.display();
                break;
            case 2:
                Console.WriteLine("Enter Stall details in comma separated(Stall Name, Stall Cost, Owner Name, Number of Projectors)");
                string inputForPremiumStall = Console.ReadLine();
                string[] premiumStallInputs = inputForPremiumStall.Split(",");
                PremiumStall manager2 = new PremiumStall(premiumStallInputs[0], Convert.ToInt32(premiumStallInputs[1]), premiumStallInputs[2], Convert.ToInt32(premiumStallInputs[3]));
                manager2.display();
                break;
            case 3:
                Console.WriteLine("Enter Stall details in comma separated(Stall Name, Stall Cost, Owner Name, Number of Screens)");
                string inputForExecutiveStall = Console.ReadLine();
                string[] executiveStallinputs = inputForExecutiveStall.Split(",");
                ExecutiveStall manager3 = new ExecutiveStall(executiveStallinputs[0], Convert.ToInt32(executiveStallinputs[1]), executiveStallinputs[2], Convert.ToInt32(executiveStallinputs[3]));
                manager3.display();
                break;
            default:
                Console.WriteLine("Oops!!! Wrong Choice");
                break;

        }
    }
}