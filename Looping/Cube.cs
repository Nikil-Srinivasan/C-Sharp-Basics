public class Cube
{
    public static void findCube()
    {
        Console.WriteLine("Input number of terms :");
        int num = Convert.ToInt32(Console.ReadLine());
        int counter = 1;
        while (counter <= num)
        {
            Console.WriteLine("Number is {0} and cube of the {1} is {2}", counter, counter, counter * counter * counter);
            counter++;
        }
    }
}