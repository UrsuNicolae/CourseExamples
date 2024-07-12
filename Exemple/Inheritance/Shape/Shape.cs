namespace Exemple.Inheritance.Shape
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
