public class VerticalMultiplicationTable
{
    public static void getVerticalTable()
    {
        Console.WriteLine("Input the number (Table to be calculated):");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int vCounter = 1; vCounter <= num; vCounter++)
        {
            for (int hCounter = 1; hCounter <= num; hCounter++)
            {
                Console.Write("{0} x {1} = {2}\t", hCounter, vCounter, num * hCounter);
            }
            Console.Write("\n");
        }
    }
}

