using Exemple.OOP;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var number1 = new ComplexNumber(1, 2);
            var number2 = new ComplexNumber(3, 4);

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
        }
    }
}
