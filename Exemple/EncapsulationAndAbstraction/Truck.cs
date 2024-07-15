namespace Exemple.EncapsulationAndAbstraction
{

    public class Truck : BaseCar
    {
        private double _loadCapacity;

        public double LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }
        public Truck(double loadCapacity, string make, string model, int year, double mileage) : base(make, model, year, mileage)
        {
            _loadCapacity = loadCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: {Make} {Model}, Year: {Year}, Mileage: {Mileage}, Load Capacity: {LoadCapacity} tons");
        }

        public override void Drive(double distance)
        {
            Mileage += distance;
            Console.WriteLine($"{Make} {Model} driven for {distance} miles. Total mileage: {Mileage}");
        }
    }

}
