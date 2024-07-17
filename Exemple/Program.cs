using Exemple.Polimorifism;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Package standart = new StandartPackage(10, 20);
            Package prioritat = new PrioritarPackage(10, 20);
            Package fragile = new FragilePackage(10, 20);
            Console.WriteLine("Standart " + standart.ToString());
            Console.WriteLine("Prioritar " + prioritat.ToString());
            Console.WriteLine("Fragil " + fragile.ToString());
        }
    }
}
