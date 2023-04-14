public class NumberPattern
{
    public static void DisplayNumberPattern()
    {
        Console.WriteLine("Enter the row size");
        int rowCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");

        for (int rowIndex = 1; rowIndex <= rowCount; rowIndex++)
        {
            for (int columnIndex = 1; columnIndex <= rowIndex; columnIndex++)
            {
                Console.Write(columnIndex + " ");
            }
            Console.Write("\n");
        }
    }
}

