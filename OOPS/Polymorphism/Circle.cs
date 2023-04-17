public class Circle : Shape
{
    private const double PI = 22 / 7.0;
    private double _circleRadius;
    public double CircleRadius
    {
        set => _circleRadius = value;
        get => _circleRadius;
    }

    public override double getShapeArea()
    {
        return PI * this.CircleRadius * CircleRadius;
    }
}