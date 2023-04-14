public class SumArray
{
    public static void getSum()
    {
        Console.Write("Input the number of elements to store in the array : ");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arraySize];
        int sum = 0;

        Console.WriteLine("\nInput {0} number of elements in the array :", arraySize);

        for (int index = 0; index < arraySize; index++)
        {
            Console.Write("Element - {0} : ", index);
            array[index] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            sum += array[index];
        }

        Console.WriteLine("Sum of all elements stored in the array is : " + sum);
    }
}