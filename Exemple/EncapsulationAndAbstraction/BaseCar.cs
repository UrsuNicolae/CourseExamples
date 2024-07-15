namespace Exemple.EncapsulationAndAbstraction
{
    public abstract class BaseCar
    {
        public BaseCar(string make, string model, int year, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private double _mileage;

        public double Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public abstract void DisplayInfo();

        public abstract void Drive(double distance);
    }
}
