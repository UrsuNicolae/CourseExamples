namespace Exemple.Solid
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }


    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }

    public class ShapeProgram
    {
        public static void Main1(string[] args)
        {
            var circle = new Circle(5);
            var square = new Square(5);
            var rectangle = new Rectangle(5, 10);
            var triangle = new Triangle(5, 10);

            CalculateAndPrintArea(circle);
            CalculateAndPrintArea(square);
            CalculateAndPrintArea(rectangle);
            CalculateAndPrintArea(triangle);
        }

        static void CalculateAndPrintArea(Shape shape)
        {
            double area = shape.CalculateArea();
            Console.WriteLine($"Area: {area}");
        }
    }
}