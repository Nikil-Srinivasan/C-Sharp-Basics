namespace Problem1.Perimeter
{
    public class Rectangle : Shape
    {
        public float Length { get; set; }
        public float Breadth { get; set; }

        public override double calculatePerimeter()
        {
            return 2 * (Length + Breadth);
        }
    }
}