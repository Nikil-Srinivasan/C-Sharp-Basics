public class FindQuadrant
{
    public static void findTheQuadrant()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Find the quadrant which the coordinate lies");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.Write("Input the value for X coordinate: ");

        int xCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for y coordinate: ");

        int yCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThe Coordinate point {0} and {1} lies in the ", xCoordinate, yCoordinate);

        if (xCoordinate > 0)
        {
            if (yCoordinate > 0)
            {
                Console.WriteLine("First Quadrant\n");
            }
            else
            {
                Console.WriteLine("Fourth Quadrant\n");
            }

        }
        else
        {
            if (yCoordinate > 0)
            {
                Console.WriteLine("Second Quadrant\n");
            }
            else
            {
                Console.WriteLine("Third Quadrant\n");
            }
        }
    }
}