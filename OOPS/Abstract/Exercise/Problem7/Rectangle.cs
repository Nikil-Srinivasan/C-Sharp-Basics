public class Rectangle : Shape
{
    public float Length { get; set; }
    public float Breadth { get; set; }

    public override float CircleArea(float radius) => 0.0f;

    public override float RectangleArea(float length, float breadth) => length * breadth;

    public override float SquareArea(float side) => 0.0f;
}