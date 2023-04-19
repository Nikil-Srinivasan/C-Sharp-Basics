public class CellPhone : DialerApp
{
    //Overrided Method to perform initiateCall
    public override void initiateCall(string receiverName)
    {
        Console.WriteLine("\n\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("  Calling {0} has been initiated  ", receiverName);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n");
    }

    //Overrided Method to perform declineCall
    public override void declineCall()
    {
        Console.WriteLine("\n\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("  Your call has been declined");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n");
    }
    public static void Main()
    {
        // customer object is created inorder to access methods and properties
        CellPhone customer = new CellPhone();

        // Get phone number and store it
        try
        {
            Console.WriteLine("Enter your phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            customer.PhoneNumber = phoneNumber;

            Console.WriteLine("\nMy Phone Number: {0} \n", customer.PhoneNumber);

            // Abstract method is overrided
            customer.initiateCall("Dad");
            customer.declineCall();

            // Abstract method is invoked
            customer.findSpamCall();
        }
        catch (Exception e)
        {
            Console.WriteLine("OOPS!!! Wrong Number");
        }


    }
}