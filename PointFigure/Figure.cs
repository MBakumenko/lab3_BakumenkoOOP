namespace PointFigure
{
    public class Figure
    {
        private Point _a;
        private Point _b;
        private Point _c;
        private Point _d;

        public Figure(Point a, Point b, Point c, Point d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)); ;
        }

        public double PerimeterCalculator()
        {
            return LengthSide(_a, _b) + LengthSide(_a, _c) + LengthSide(_a, _d) + LengthSide(_b, _c) + LengthSide(_b, _d) + LengthSide(_c, _d);
        }
    }
}