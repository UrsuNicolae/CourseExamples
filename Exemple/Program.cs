using Exemple.OOP;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            IMovable car = new MovableCar();
            IMovable plane = new Plane();

            List<IMovable> movables = new List<IMovable> { car, plane };
            foreach(var movable in movables)
            {
                movable.Move();
            }
        }
    }
}
