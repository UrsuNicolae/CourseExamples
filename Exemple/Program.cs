namespace Exemple
{
    internal class Program
    {
        public class Vehicle
        {
            public virtual void DisplayInfo()
            {
                Console.WriteLine("Informati generica despre vehicul");
            }
        }

        public class Car : Vehicle
        {
            public override void DisplayInfo()
            {
                Console.WriteLine("Informatii despre masina");
            }
        }

        public class Bicicle : Vehicle
        {

            public new void DisplayInfo()
            {
                Console.WriteLine("Informatii despre bicicleta");
            }
        }

        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle bicile = new Bicicle();
            car.DisplayInfo();
            bicile.DisplayInfo();
        }
    }
}
