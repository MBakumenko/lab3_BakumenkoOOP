namespace Rectangle
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        private double AreaCalculator() => _side1 * _side2;
        private double PerimeterCalculator() => 2 * (_side1 + _side2);

        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();
    }
}