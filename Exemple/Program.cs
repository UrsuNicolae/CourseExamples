using Exemple.OOP;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var operations = new MathOperations();
            var result1 = operations.Add(1, 2);
            var result2 = operations.Add(1.1, 2.2);
        }
    }
}
