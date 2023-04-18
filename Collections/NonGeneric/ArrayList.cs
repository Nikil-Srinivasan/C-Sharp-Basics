using System.Collections;

public class ArrayListExample
{
    public static void arrayListMethods()
    {
        var surpriseGift = new ArrayList()
        {
            "Ballon", null, "Free trip to Goa", false, "Car", false
        };

        try
        {
            Console.WriteLine("Enter number (1 to 5): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Gift: {0}\n\n", surpriseGift[choice - 1]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        // Add element at 1st index
        surpriseGift.Insert(1, "Chocolate");

        //Removes first occurance of false
        surpriseGift.Remove(false);

        // surpriseGift.Sort(); 
        // Runtime Exception: We cannot sort ArrayList containing different data type

        surpriseGift.Reverse();

        // Iterate ArrayList using index
        for (int index = 0; index < surpriseGift.Count; index++)
        {
            Console.WriteLine("Gift Available: " + surpriseGift[index]);
        }


    }
}