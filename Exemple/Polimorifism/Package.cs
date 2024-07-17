namespace Exemple.Polimorifism
{
    public abstract class Package
    {

        public double Weight { get; set; }
        public double Distance { get; set; }

        protected Package(double weight, double distance)
        {
            Weight = weight;
            Distance = distance;
        }

        public abstract double CalculateShippingCosts();

        public override string ToString()
        {
            return $"Shipping cost is: {CalculateShippingCosts()}";
        }
    }

    public class StandartPackage : Package
    {
        public StandartPackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCosts()
        {
            return 0.5 * Weight + 0.1 * Distance;
        }
    }

    public class PrioritarPackage : Package
    {
        public PrioritarPackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCosts()
        {
            return 0.5 * Weight + 0.5 * Distance;
        }
    }

    public class FragilePackage : Package
    {
        public FragilePackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCosts()
        {
            return 1 * Weight + 0.5 * Distance;
        }
    }
}
