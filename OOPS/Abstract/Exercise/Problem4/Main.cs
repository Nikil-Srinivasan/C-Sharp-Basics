public class MainProg
{
    public static void main()
    {
        StudentA ramu = new StudentA(98, 87, 54);
        System.Console.WriteLine("\nThe percentage of Ramu is {0:F}\n", ramu.getPercentage());

        StudentB somu = new StudentB(98, 87, 54, 35);
        System.Console.WriteLine("The percentage of Somu is {0:F}\n", somu.getPercentage());

    }
}