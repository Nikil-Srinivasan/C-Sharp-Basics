public class QueueExample
{
    public static void queueMethods()
    {
        var customerQueue = new Queue<string>();

        customerQueue.Enqueue("Person 1");
        customerQueue.Enqueue("Person 2");
        customerQueue.Enqueue("Person 3");
        customerQueue.Enqueue("Person 4");

        // Check the first person and remove him
        Console.WriteLine(customerQueue.Dequeue() + "\n");

        // Check the first person only
        Console.WriteLine(customerQueue.Peek() + "\n");

        foreach (var customerOrder in customerQueue)
        {
            Console.WriteLine(customerOrder);
        }

        customerQueue.Clear();

    }
}