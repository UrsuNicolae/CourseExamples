using Exemple.ClassAndObject;

namespace Exemple
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person("Nicu", 10);

            p.DisplayInfo();
            p2.DisplayInfo();
        }
    }
}
