public class Circle : Shape
{
    const float PI = 3.14f;
    public float Radius { get; set; }
    public override double calculatePerimeter()
    {
        return 2 * PI * Radius;
    }
}