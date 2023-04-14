public class ReverseArray
{
    public static void toReverseArray()
    {
        Console.Write("Input the number of elements to store in the array : ");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arraySize];

        Console.WriteLine("\nInput {0} number of elements in the array :", arraySize);

        for (int index = 0; index < arraySize; index++)
        {
            Console.Write("Element - {0} : ", index);
            array[index] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
        }

        Console.WriteLine("\nThe values store into the array are:");
        for (int index = 0; index < arraySize; index++)
        {
            Console.Write(array[index] + " ");
        }

        Array.Reverse(array);

        Console.WriteLine("\n\nThe values store into the array in reverse are:");
        for (int index = 0; index < arraySize; index++)
        {
            Console.Write(array[index] + " ");
        }
    }
}