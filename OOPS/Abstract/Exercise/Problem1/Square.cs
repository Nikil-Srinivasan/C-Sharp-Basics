namespace Problem1.Perimeter
{
    public class Square : Shape
    {
        public float Side { get; set; }
        public override double calculatePerimeter()
        {
            return Side * 4;
        }
    }
}