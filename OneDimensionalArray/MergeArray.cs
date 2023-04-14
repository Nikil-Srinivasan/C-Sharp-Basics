public class MergeArray
{
    public static void performMerge()
    {
        Console.Write("Input the number of elements to store in the 1st array : ");
        int arraySize1 = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[arraySize1];
        Console.WriteLine("\nInput {0} number of elements in the array :", arraySize1);
        for (int index = 0; index < arraySize1; index++)
        {
            Console.Write("Element - {0} : ", index);
            array1[index] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
        }

        Console.Write("Input the number of elements to store in the 2nd array : ");
        int arraySize2 = Convert.ToInt32(Console.ReadLine());
        int[] array2 = new int[arraySize2];
        Console.WriteLine("\nInput {0} number of elements in the array :", arraySize2);
        for (int index = 0; index < arraySize2; index++)
        {
            Console.Write("Element - {0} : ", index);
            array2[index] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
        }
        int[] array3 = new int[arraySize1 + arraySize2];
        Array.Copy(array1, array3, arraySize1);
        Array.Copy(array2, 0, array3, arraySize1, arraySize2);
        Array.Sort(array3);
        Console.WriteLine("\n\nThe merged array in ascending order is:");
        for (int index = 0; index < arraySize1 + arraySize2; index++)
        {
            Console.Write(array3[index] + " ");
        }
    }
}