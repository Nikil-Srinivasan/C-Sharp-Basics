namespace Overloading
{
    public class Square : Shapes
    {
        public override double getShapeArea()
        {
            return this.ShapeLength * this.ShapeLength;
        }
    }
}