public class DriverProgram
{
    public static void Main()
    {
        Console.WriteLine("List of Shapes:\n1.Circle\n2.Rectangle\n3.Square\nEnter your choice:");
        int choiceOfShape = Convert.ToInt32(Console.ReadLine());
        switch (choiceOfShape)
        {
            case 1:
                Console.WriteLine("Enter the radius of the Circle:");
                float circleRadius = float.Parse(Console.ReadLine());
                Circle newCircle = new Circle();
                newCircle.Radius = circleRadius;
                Console.WriteLine("The perimeter is {0:F}", newCircle.calculatePerimeter());
                break;

            case 2:
                Console.WriteLine("Enter the length of the Rectangle:");
                float rectangleLength = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the breadth of the Rectangle:");
                float rectangleBreadth = float.Parse(Console.ReadLine());
                Rectangle newRectangle = new Rectangle();
                newRectangle.Length = rectangleLength;
                newRectangle.Breadth = rectangleBreadth;
                Console.WriteLine("The perimeter is {0:F}", newRectangle.calculatePerimeter());
                break;
            case 3:
                Console.WriteLine("Enter the side of the Sqaure:");
                float squareSide = float.Parse(Console.ReadLine());
                Square newSquare = new Square();
                newSquare.Side = squareSide;
                Console.WriteLine("The perimeter is {0:F}", newSquare.calculatePerimeter());
                break;
            default:
                Console.WriteLine("Oops!!! Wrong Choice");
                break;
        }
    }
}