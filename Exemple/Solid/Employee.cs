using System.Xml.Linq;

namespace Exemple.Solid
{
    class SalaryCalculator
    {
        public void CalculatePay(Employee employee)
        {
            Console.WriteLine($"Calculating pay for {employee.Name}...");
        }
    }

    class DbSave
    {
        public void Save(Employee employee)
        {
            Console.WriteLine($"Saving {employee.Name} to the database...");
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "John", Salary = 50000 };
            SalaryCalculator calculator = new SalaryCalculator();
            DbSave dbSaver = new DbSave();
            calculator.CalculatePay(employee);
            dbSaver.Save(employee);
        }
    }
}
