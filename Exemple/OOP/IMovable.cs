namespace Exemple.OOP
{
    public interface IMovable
    {
        void Move();
    }

    public class MovableCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Plane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Plane is flying");
        }
    }
}
