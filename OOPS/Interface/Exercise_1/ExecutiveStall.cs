public class ExecutiveStall : IStall
{

    public string StallName { get; set; }
    public int Cost { get; set; }
    public string OwnerName { get; set; }
    public int Screen { get; set; }

    ExecutiveStall()
    {

    }

    public ExecutiveStall(string stallName, int cost, string ownerName, int screen)
    {
        StallName = stallName;
        Cost = cost;
        OwnerName = ownerName;
        Screen = screen;
    }

    public void display()
    {
        Console.WriteLine("Stall Name: {0}", StallName);
        Console.WriteLine("Cost of the Stall: {0}", Cost);
        Console.WriteLine("Owner Name: {0}", OwnerName);
        Console.WriteLine("Number of Screens: {0}", Screen);
    }
}