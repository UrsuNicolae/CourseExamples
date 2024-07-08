namespace Exemple.OOP
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }

    public class Truck : Vehicle
    {
        public int CargoCapity { get; set; }
    }
}
