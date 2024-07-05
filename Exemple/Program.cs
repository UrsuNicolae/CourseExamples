using Exemple.ClassAndObject;
using System.Security.Cryptography.X509Certificates;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*Person p = new Person();
            Person p2 = new Person("Nicu", 10);

            p.DisplayInfo();
            p2.DisplayInfo();*/

            /*var counter1 = new Counter();
            counter1.DisplayCount();
            var counter2 = new Counter();
            counter1.DisplayCount();
            var counter3 = new Counter();
            counter3.DisplayCount();
            var counter4 = new Counter();
            counter2.DisplayCount();*/

            /*Console.WriteLine($"10 + 21 = {Calculator.Add(10, 21)}");
            Console.WriteLine($"10 - 21 = {Calculator.Subtract(10, 21)}");
            Console.WriteLine($"10 * 21 = {Calculator.Multiply(10, 21)}");
            Console.WriteLine($"10 / 21 = {Calculator.Devide(10, 21)}");*/

            /*var resourse = new Resource("test path");
            resourse.UseResource();
            resourse.UseResource();
            resourse.UseResource();*/

            /*var manager = new EmployeeManager();
            manager.AddIntern("Nicu", 21);
            manager.AddDeveloper("Vasile", 33);
            manager.AddAccountant("Ina", 24);
            manager.AddDesigner("Irina", 27);

            manager.DisplayEmployeesUnder25();
            foreach(var developer in manager.GetDevelopers())
            {
                Console.WriteLine(developer.Name);
            }*/

            var inventory = new Inverntory();
            try
            {
                var product = inventory[0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Elementul este inexistent!");
            }
            inventory.AddProduct(new Product("telefon", 0.2));
            var productExistent = inventory[0];
            Console.WriteLine(productExistent.GetProductName());
        }
    }
}
