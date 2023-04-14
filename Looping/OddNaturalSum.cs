public class OddNaturalSum
{
    public static void getOddSum()
    {
        Console.WriteLine("Input number of terms:");
        int num = Convert.ToInt32(Console.ReadLine());
        int oddSum = 0;

        Console.Write("\nThe odd numbers are : ");

        for (int counter = 1; counter <= num * 2; counter += 2)
        {
            Console.Write(counter + " ");
            oddSum += counter;
        }

        Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms: {1}", num, oddSum);

    }
}

