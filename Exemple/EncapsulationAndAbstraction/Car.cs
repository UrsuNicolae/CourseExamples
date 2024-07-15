namespace Exemple.EncapsulationAndAbstraction
{
    public class Car : BaseCar
    {

        private int _numberOfDoors;

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set { _numberOfDoors = value; }
        }

        public Car(int numberOfDors, string make, string model, int year, double mileage) : base(make, model, year, mileage)
        {
            NumberOfDoors = numberOfDors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model}, Year: {Year}, Mileage: {Mileage}, Doors: {NumberOfDoors}");
        }

        public override void Drive(double distance)
        {
            Mileage += distance;
            Console.WriteLine($"{Make} {Model} driven for {distance} miles. Total mileage: {Mileage}");
        }
    }
}
