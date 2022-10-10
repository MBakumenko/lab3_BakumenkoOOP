using System.Text;

namespace Rectangle
{
    internal class Program
    {
        static void Warning()
        {
            throw new ArgumentException("Сторона не може бути меншим за 0");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double side1, side2;
            Console.WriteLine("Введіть довжину першої сторони");
            if (!double.TryParse(Console.ReadLine(), out side1) || side1 < 0)
            {
                Warning();
            }
            Console.WriteLine("Введіть довжину другої сторони");
            if (!double.TryParse(Console.ReadLine(), out side2) || side2 < 0)
            {
                Warning();
            }

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа: {rectangle.Area}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");
        }
    }
}
