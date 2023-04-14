public class MultiplicationTable
{
    public static void calculateTable()
    {
        Console.WriteLine("Input the number (Table to be calculated):");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int counter = 1; counter <= 10; counter++)
        {
            Console.WriteLine("{0} x {1} = {2}", num, counter, num * counter);
        }
    }
}