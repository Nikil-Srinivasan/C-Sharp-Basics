public class MainProgram
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.ShapeLength = 10;
        rectangle.ShapeWidth = 5;
        Console.WriteLine("The area of rectangle is " + rectangle.getShapeArea());

        Circle circle = new Circle();
        circle.CircleRadius = 5;
        Console.WriteLine("The area of circle is {0}", circle.getShapeArea());

    }
}