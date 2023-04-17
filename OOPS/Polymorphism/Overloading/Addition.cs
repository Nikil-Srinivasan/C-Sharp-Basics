public class Addition
{
    public int add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public float add(float num1, float num2, float num3)
    {
        return num1 + num2 + num3;
    }

    public int add(int num1, int num2)
    {
        return num1 + num2;
    }

    public float add(float num1, float num2)
    {
        return num1 + num2;
    }

    public static void performAddition()
    {
        Addition addition = new Addition();
        Console.WriteLine("Sum of 10 and 20 is " + addition.add(10, 20));
        Console.WriteLine("Sum of 10, 20 and 30 is" + addition.add(10, 20, 30));
        Console.WriteLine("Sum of 10.54 and 20.34 is" + addition.add(10.54F, 20.34F));
        Console.WriteLine("Sum of 10.54 and 20.34 and 34.4 is" + addition.add(10.54F, 20.34F, 34.4F));
    }

}