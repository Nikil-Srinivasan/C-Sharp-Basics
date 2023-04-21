public class GoldStall : IStall
{
    public string StallName { get; set; }
    public int Cost { get; set; }
    public string OwnerName { get; set; }
    public int TvSet { get; set; }

    public GoldStall()
    {

    }

    public GoldStall(string stallName, int cost, string ownerName, int tvSet)
    {
        StallName = stallName;
        Cost = cost;
        OwnerName = ownerName;
        TvSet = tvSet;
    }

    public void display()
    {
        Console.WriteLine("Stall Name: {0}", StallName);
        Console.WriteLine("Cost of the Stall: {0}", Cost);
        Console.WriteLine("Owner Name: {0}", OwnerName);
        Console.WriteLine("Number of TV Set: {0}", TvSet);
    }
}