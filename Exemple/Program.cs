using Exemple.ClassAndObject;
using Exemple.Inheritance;
using System.Security.Cryptography.X509Certificates;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Punct punct = new Punct(3,4);
            punct.Scrie();


            //Apelul constructorului clasei de derivate
            Linie linie = new Linie(2, 2, 10, 10);
            linie.Scrie();
        }
    }
}
