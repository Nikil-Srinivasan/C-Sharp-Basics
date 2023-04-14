// Program to read 10 numbers from keyboard and find their sum and average
public class AverageOfIntegers
{
    public static void hgvgh()
    {
        Console.WriteLine("\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Read 10 numbers find their sum and average");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Input the 10 numbers:");

        int sum = 0;
        for (int counter = 1; counter <= 10; counter++)
        {
            Console.Write("\nNumber {0} : ", counter);
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        Console.Write("\nThe sum of 10 numbers is: {0}", sum);

        double average = sum / 10.0;
        Console.WriteLine("\nThe average is: {0}", average);
    }
}