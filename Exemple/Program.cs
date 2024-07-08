using Exemple.OOP;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var circle = new Circle { Radius = 5 };
            var rectangle = new Rectangle { Width = 5, Height = 10 };
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());
        }
    }
}
