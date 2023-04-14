// This code Checks whether the integer is even or odd and prints the result to the console
public class IsEvenOrOdd
{
    public static void checkEvenOrOdd()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Check whether given number is even or odd");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input an Integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("\n\n{0} is an even\n\n", num);
        }
        else
        {
            Console.WriteLine("\n\n{0} is an odd\n\n", num);
        }
    }
}

