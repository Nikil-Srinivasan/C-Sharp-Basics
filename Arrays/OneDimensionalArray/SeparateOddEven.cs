public class SeparateOddEven
{
    public static void doSeparate()
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

        int[] oddArray = new int[arraySize];
        int[] evenArray = new int[arraySize];
        int i = 0, j = 0;
        for (int index = 0; index < arraySize; index++)
        {
            if (array[index] % 2 == 0)
            {
                evenArray[i++] = array[index];
            }
            else
            {
                oddArray[j++] = array[index];
            }
        }
        Console.WriteLine("The Even Elements are:");
        for (int index = 0; index < i; index++)
        {
            Console.Write(evenArray[index] + " ");
        }
        Console.WriteLine("\nThe Odd Elements are:");
        for (int index = 0; index < j; index++)
        {
            Console.Write(oddArray[index] + " ");
        }
    }
}
