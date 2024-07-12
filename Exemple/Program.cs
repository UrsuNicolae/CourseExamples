
using Exemple.Inheritance.School;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            object studen = new Student("ion", 20, 5);
            Person teacher = new Teacher("gigel", 30, "math");

            Console.WriteLine(studen);
            Console.WriteLine(teacher);

        }
    }
}
