using Exemple.EncapsulationAndAbstraction.EmployeeManagement;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new EmployeeManger();
            manager.AddEmployee(new FullTimeEmployee("John", "123", 50000));
            manager.AddEmployee(new ParTimeEmployee("Nick", "1323", 20000));

            manager.DisplayAllEmployees();
        }
    }
}
