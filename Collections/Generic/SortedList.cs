public class SortedListExample
{
    public static void Main()
    {
        SortedList<string, int> customerDetails = new SortedList<string, int>();

        // Add elements to list
        customerDetails.Add("Nikil", 20);
        customerDetails.Add("Kavin", 21);
        customerDetails.Add("Sujith", 19);
        customerDetails.Add("Vicky", 20);
        customerDetails.Add("Satha", 21);

        //accessing elements using foreach
        foreach (var kvp in customerDetails)
        {
            Console.WriteLine("Customer Name : {0} \t Age: {1}", kvp.Key, kvp.Value);
        }

        // Checking the capacity of SortedList
        Console.WriteLine("Capacity of SortedList: " + customerDetails.Capacity);

    }
}