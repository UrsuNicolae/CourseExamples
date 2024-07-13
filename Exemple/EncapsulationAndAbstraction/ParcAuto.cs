namespace Exemple.EncapsulationAndAbstraction
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double Mileage;
        public int NumberOfDoors;

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model}, Year: {Year}, Mileage: {Mileage}, Doors: {NumberOfDoors}");
        }

        public void Drive(double distance)
        {
            Mileage += distance;
            Console.WriteLine($"{Make} {Model} driven for {distance} miles. Total mileage: {Mileage}");
        }
    }

    public class Truck
    {
        public string Make;
        public string Model;
        public int Year;
        public double Mileage;
        public double LoadCapacity;

        public void DisplayInfo()
        {
            Console.WriteLine($"Truck: {Make} {Model}, Year: {Year}, Mileage: {Mileage}, Load Capacity: {LoadCapacity} tons");
        }

        public void Drive(double distance)
        {
            Mileage += distance;
            Console.WriteLine($"{Make} {Model} driven for {distance} miles. Total mileage: {Mileage}");
        }
    }

}
