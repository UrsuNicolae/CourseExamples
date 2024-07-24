using Exemple.Genercs;
using Exemple.Linq;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Nick", Age = 25, Department = "HR" });
            employees.Add(new Employee { Id = 2, Name = "Jane", Age = 30, Department = "IT" });
            employees.Add(new Employee { Id = 3, Name = "Marie", Age = 26, Department = "IT" });
            employees.Add(new Employee { Id = 4, Name = "Fill", Age = 22, Department = "HR" });
            employees.Add(new Employee { Id = 5, Name = "Annie", Age = 25, Department = "HR" });

            var employeesAfter25 = employees
                .Where(e => e.Age > 22)
                .OrderBy(e => e.Name)
                .Select(e => new {e.Name, e.Age});

            foreach (var employee in employeesAfter25)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            }
        }
    }
}
