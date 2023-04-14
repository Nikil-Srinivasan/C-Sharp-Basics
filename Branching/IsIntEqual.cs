// This code Checks the equality of two integers and prints the result to the console
public class IsIntEqual
{
    public static void checkEqual()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Check whether two integers equal or not");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("\n\n{0} and {1} are equal\n\n", num1, num2);
        }
        else
        {
            Console.WriteLine("\n\n{0} and {1} are not equal\n\n", num1, num2);
        }
    }
}

