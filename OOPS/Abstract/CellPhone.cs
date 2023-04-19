public class CellPhone : DialerApp
{
    public override void initiateCall(string receiverName)
    {
        Console.WriteLine("\n\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("  Calling {0} has been initiated  ", receiverName);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n");
    }

    public override void declineCall()
    {
        Console.WriteLine("\n\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("  Your call has been declined");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n");
    }
    public static void Main()
    {
        CellPhone customer = new CellPhone();
        Console.WriteLine("\nMy Phone Number: {0} \n", customer.phoneNumber);
        customer.initiateCall("Dad");
        customer.declineCall();
        customer.findSpamCall();
    }
}