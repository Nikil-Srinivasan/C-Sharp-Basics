// Display the sum of first 10 natural numbers
public class SumNaturalNumbers
{
    public static void getSum()
    {
        Console.WriteLine("\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Find the sum of first 10 natural numbers");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        int sum = 0;

        for (int counter = 1; counter <= 10; counter++)
        {
            sum += counter;
        }

        Console.WriteLine("The sum is: {0}\n", sum);
    }
}

