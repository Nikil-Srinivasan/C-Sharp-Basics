public class CategorizePersonHeight
{
    public static void doCategorizePerson()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Accept the height of a person in centimeter and categorize them");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input the height of the person (in centimetres): ");
        double personHeight = Convert.ToDouble(Console.ReadLine());

        if (personHeight >= 195.0)
        {
            Console.WriteLine("\nAbnormal height\n\n");
        }
        else if (personHeight >= 165.0)
        {
            Console.WriteLine("\nThe person is taller\n\n");
        }
        else if (personHeight >= 150.0)
        {
            Console.WriteLine("\nThe person is average heighted\n\n");
        }
        else
        {
            Console.WriteLine("\nThe person is dwarf\n\n");
        }
    }
}