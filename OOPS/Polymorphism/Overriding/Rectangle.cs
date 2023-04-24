namespace Overloading
{
    public class Rectangle : Shapes
    {
        public override double getShapeArea()
        {
            return this.ShapeLength * this.ShapeWidth;
        }
    }
}