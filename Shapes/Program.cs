namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.GetArea());
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine(rectangle.GetArea());
            Console.ReadKey();
        }
    }
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return double.Pi * Radius * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }
    }
}

