using Exemple.ClassAndObject;
using Exemple.Inheritance;
using System.Security.Cryptography.X509Certificates;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Punct punct = new Punct();
            //punct.x = 0; punct.y = 0; acces restrictionat
            punct.Scrie();
            Linie linie = new Linie();
            //linie.x = 0; linie.y = 0;acces restrictionat
            linie.xEnd = 10; linie.yEnd = 10;
            linie.Scrie();
        }
    }
}
