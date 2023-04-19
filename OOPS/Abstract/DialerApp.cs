public abstract class DialerApp
{

    public long phoneNumber = 9876543210;
    public abstract void initiateCall(string receiverName);
    public abstract void declineCall();
    public void findSpamCall()
    {
        Console.WriteLine("Spam Call has been blocked !!!");
    }
}