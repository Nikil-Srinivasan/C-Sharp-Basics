public class Stack
{
    public static void performStackOperations()
    {
        Stack<string> navigation = new Stack<string>();

        // Add elements to stack
        navigation.Push("Page 1");
        navigation.Push("Page 2");
        navigation.Push("Page 3");
        navigation.Push("Page 4");
        navigation.Push("Page 5");

        foreach (var page in navigation)
        {
            Console.WriteLine(page);
        }

        // Viewing the count of stack elements
        Console.WriteLine("\nNumber of pages navigated: {0}\n", navigation.Count);

        // Viewing top element of stack
        Console.WriteLine("Current Page : {0}\n", navigation.Peek());

        while (navigation.Count > 0)
        {
            //Remove top element of stack
            Console.Write(navigation.Pop());
            if (navigation.Count != 0)
                Console.Write(" => ");
        }

        Console.WriteLine("\n\nNumber of pages navigated: {0}\n", navigation.Count);

        //create a Stack from an array
        int[] array = new int[] { 1, 2, 3, 4 };
        Stack<int> myStack = new Stack<int>(array);

        foreach (var item in myStack)
            Console.WriteLine(item);

    }
}