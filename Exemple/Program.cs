using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var intTree = new BinarySerachTeary<int>();
            intTree.Insert(10);
            intTree.Insert(5);
            intTree.Insert(15);
            intTree.Insert(3);

            intTree.Display();

            Console.WriteLine(intTree.Search(20));
        }
    }
}
