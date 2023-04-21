public class Dogs : Animals
{
    public override void callCats() { }

    public override void callDogs()
    {
        System.Console.WriteLine("Dogs bark");
    }
}