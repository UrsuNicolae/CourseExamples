using Exemple.ClassAndObject;
using Exemple.ClassMembers;
using Exemple.Polimorifism;
using System.Runtime.CompilerServices;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produs> produse = new List<Produs>
            {
                new Produs("carte", "roman", 10, 0),
                new Produs("pix", "albastru", 1, 0.5m)
            };

            foreach (var produs in produse)
            {
                Console.WriteLine(produs);
                produs.ApplyDiscountRate(5m);
            }
            foreach (var produs in produse)
            {
                Console.WriteLine(produs);
            }
        }
    }
}
