public class PremiumStall : IStall
{
    public string StallName { get; set; }
    public int Cost { get; set; }
    public string OwnerName { get; set; }
    public int Projector { get; set; }
    PremiumStall()
    {

    }
    public PremiumStall(string stallName, int cost, string ownerName, int projector)
    {
        StallName = stallName;
        Cost = cost;
        OwnerName = ownerName;
        Projector = projector;
    }

    public void display()
    {
        Console.WriteLine("Stall Name: {0}", StallName);
        Console.WriteLine("Cost of the Stall: {0}", Cost);
        Console.WriteLine("Owner Name: {0}", OwnerName);
        Console.WriteLine("Number of Projectors: {0}", Projector);
    }
}