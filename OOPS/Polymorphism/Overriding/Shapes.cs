namespace Overloading
{
    public class Shapes
    {
        private double _shapeLength;
        private double _shapeWidth;

        public double ShapeLength
        {
            get => _shapeLength;
            set => _shapeLength = value;
        }

        public double ShapeWidth
        {
            get => _shapeWidth;
            set => _shapeWidth = value;
        }

        public virtual double getShapeArea()
        {
            return this.ShapeLength * this.ShapeWidth;
        }


    }
}