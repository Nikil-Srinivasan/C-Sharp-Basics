public abstract class DialerApp
{

    public long PhoneNumber { get; set; }

    // Call is initiated with customer and receiver
    public abstract void initiateCall(string receiverName);

    // Call is ended with customer and receiver
    public abstract void declineCall();

    // To find and block the spam calls
    public virtual void findSpamCall()
    {
        Console.WriteLine("Spam Call has been blocked !!!");
    }
}