// This code Checks whether the integer is positive or negative and prints the result to the console
public class IsPositiveOrNegative
{
    public static void CheckPositiveOrNegative()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Check whether given number is positive or negative");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input an Integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
        {
            Console.WriteLine("\n\n{0} is a positive number\n\n", num);
        }
        else
        {
            Console.WriteLine("\n\n{0} is a negative number\n\n", num);
        }
    }
}

