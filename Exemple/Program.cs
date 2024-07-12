
using Exemple.Inheritance.School;
using Exemple.Inheritance.Shape;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
        }
    }
}
