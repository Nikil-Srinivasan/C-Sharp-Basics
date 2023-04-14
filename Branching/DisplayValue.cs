public class DisplayValue
{
    public static void displayValue()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Display the value of n according to the value of m");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input the value of m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int n;

        if (m != 0)
        {
            if (m > 0)
            {
                n = 1;
            }
            else
            {
                n = -1;
            }
        }
        else
        {
            n = 0;
        }

        Console.WriteLine("\nThe value of m = {0} \n", m);
        Console.WriteLine("The value of n = {0} \n", n);
    }
}

