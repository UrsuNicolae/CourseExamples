namespace Exemple.EncapsulationAndAbstraction.EmployeeManagement
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, string id, double salary) : base(name, id, salary)
        {
        }

        public override void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}, Employee Type: Full Time");
        }

        public override void Work()
        {
            Console.WriteLine("Working full time...");
        }
    }
}
