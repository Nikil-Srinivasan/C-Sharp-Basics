using System.Collections;

public class HashTableExample
{
    public static void Main()
    {
        Hashtable groceryList = new Hashtable();

        groceryList.Add(1, "Apple");
        groceryList.Add(2, "Banana");
        groceryList.Add(3, "Carrot");
        groceryList.Add(4, "Tomato");

        Console.WriteLine("Grocery List:\n");
        // Iterating using object both key and value will be displayed
        // obj.Key or obj.Value is not available in object
        foreach (object groceryItem in groceryList)
        {
            Console.Write(groceryItem + " ");
        }

        // Removing Banana by checking with its Key
        if (groceryList.ContainsKey(2))
        {
            groceryList.Remove(2);
        }

        Console.WriteLine("\n\nGrocery List:\n");
        // Iterating using DictionaryEntry for accessing only the value
        foreach (DictionaryEntry groceryItem in groceryList)
        {
            Console.WriteLine("Grocery item: {0}", groceryItem.Value);
        }

        Console.WriteLine("Total item in grocery list: " + groceryList.Count);

    }
}