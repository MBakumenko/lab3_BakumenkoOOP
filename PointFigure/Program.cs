namespace PointFigure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 5, "A"), new Point(2, 4, "B"), new Point(3, 1, "C"), new Point(2, 1, "D"));
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}