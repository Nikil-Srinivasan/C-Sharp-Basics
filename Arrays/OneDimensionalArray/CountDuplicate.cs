public class CountDuplicate
{
    public static void getCount()
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
        int duplicateCount = 0;
        for (int i = 0; i < arraySize; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                duplicateCount++;
            }
        }
        Console.WriteLine("The number of duplicate element is {0}", duplicateCount);
    }
}