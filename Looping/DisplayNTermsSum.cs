// Display n terms natural numbers with their sum
public class DisplayNTermsSum
{
    public static void toDisplay()
    {
        Console.WriteLine("\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Display n terms of natural number and their sum");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input value of terms:");
        int terms = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        Console.WriteLine("\nThe first {0} natural number is:\n", terms);

        for (int counter = 1; counter <= terms; counter++)
        {
            Console.WriteLine("{0} ", counter);
            sum += counter;
        }

        Console.WriteLine("\nThe Sum of Natural Numbers upto {0} terms is {1}", terms, sum);
    }
}

