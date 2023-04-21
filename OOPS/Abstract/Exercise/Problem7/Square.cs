public class Square : Shape
{
    public float Side { get; set; }

    public override float CircleArea(float radius) => 0.0f;

    public override float RectangleArea(float length, float breadth) => 0.0f;

    public override float SquareArea(float side) => side * side;
}