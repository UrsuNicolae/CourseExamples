using Exemple.ClassMembers;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Dacia", "Logan", 2005, 0);
            car.DisplayInfo();
            car.Accelerate();
            Console.WriteLine($"Speed: {car.Speed}");
            car.Decelerate();
            car.Decelerate();
            car.Decelerate();
            Console.WriteLine($"Speed: {car.Speed}");

            var car2 = new Car(car);
            car2.DisplayInfo();
        }
    }
}
