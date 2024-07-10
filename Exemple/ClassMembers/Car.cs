namespace Exemple.ClassMembers
{
    public class Car
    {
        private string Producator;
        private string Model;
        private int AnFabricatie;
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if(value < 0)
                {

                   speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Car(string producator, string model, int anFabricatie)
        {
            Producator = producator;
            Model = model;
            AnFabricatie = anFabricatie;
        }

        public Car(string producator, string model, int anFabricatie, int speed) : this(producator, model, anFabricatie)
        {
            Speed = speed;
        }

        public Car(Car car) : this(car.Producator, car.Model, car.AnFabricatie, car.Speed)
        {
        }

        ~Car()
        {
            Console.WriteLine("Obiectul a fost distrus");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Producator: {Producator}, Model: {Model}, An fabricatie: {AnFabricatie}");
        }

        public void Accelerate()
        {
            Speed += 10;
        }

        public void Decelerate()
        {
            Speed -= 10;
        }
    }
}
