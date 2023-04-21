public class Circle : Shape
{
    const float PI = 3.14f;
    public override float CircleArea(float radius) => PI * radius * radius;

    public override float RectangleArea(float length, float breadth) => 0.0f;

    public override float SquareArea(float side) => 0.0f;
}