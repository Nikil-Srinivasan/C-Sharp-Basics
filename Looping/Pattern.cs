public class Pattern
{
    public static void displayPattern()
    {
        Console.WriteLine("Enter the row size");
        int rowCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");

        for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex <= rowIndex; columnIndex++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
    }
}

