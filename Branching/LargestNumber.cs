public class LargestNumber
{
    public static void findLargestNumber()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Find the largest of three numbers");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("\n\nThe 1st Number is greatest among three\n");
        }
        else if (num2 > num3)
        {
            Console.WriteLine("\n\nThe 2nd Number is greatest among three\n");
        }
        else
        {
            Console.WriteLine("\n\nThe 3rd Number is greatest among three\n");
        }
    }
}