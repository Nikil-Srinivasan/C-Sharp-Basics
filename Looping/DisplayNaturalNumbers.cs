// Display first 10 natural numbers
public class DisplayNaturalNumbers
{
    public static void getDisplay()
    {
        Console.WriteLine("\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Display the first 10 natural numbers");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.WriteLine("The first 10 natural number is:\n");

        for (int counter = 1; counter <= 10; counter++)
        {
            Console.WriteLine("{0} ", counter);
        }
    }
}