// This code Checks whether the given year is leap or not and prints the result to the console
public class IsLeapYear
{
    public static void checkLeapYear()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Check whether given year is Leap year or not");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input an year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("\n{0} is a Leap Year\n\n", year);
        }
        else
        {
            Console.WriteLine("\n{0} is Not a Leap Year\n\n", year);
        }
    }
}

