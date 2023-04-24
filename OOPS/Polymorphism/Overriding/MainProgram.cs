namespace Overloading
{
    public class MainProgram
    {
        public static void findArea()
        {
            Shapes rectangle = new Rectangle();
            rectangle.ShapeLength = 10;
            rectangle.ShapeWidth = 5;
            Console.WriteLine("The area of rectangle is " + rectangle.getShapeArea());

            Shapes square = new Square();
            square.ShapeLength = 10;
            Console.WriteLine("The area of square is " + square.getShapeArea());

        }
    }
}