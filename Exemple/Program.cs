using Exemple.ClassMembers;
using Exemple.Encapsulation;
using Exemple.EncapsulationAndAbstraction;
using System.Runtime.CompilerServices;
using Car = Exemple.EncapsulationAndAbstraction.Car;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCar car = new Car(4, "bmw", "seria 5", 2022, 50000 );
            car.DisplayInfo();


            BaseCar truck = new Truck(2000, "volvo", "asdafa", 2000, 300000);
            truck.DisplayInfo();
        }
    }
}
