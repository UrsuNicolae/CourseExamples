
using Exemple.Inheritance.DiamondProblem;
using Exemple.Inheritance.School;
using Exemple.Inheritance.Shape;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            IRight diamond = new Diamond();
            diamond.DoWork();
        }
    }
}
