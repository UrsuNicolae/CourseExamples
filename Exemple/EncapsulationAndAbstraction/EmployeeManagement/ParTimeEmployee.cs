namespace Exemple.EncapsulationAndAbstraction.EmployeeManagement
{
    public class ParTimeEmployee : Employee
    {
        public ParTimeEmployee(string name, string id, double salary) : base(name, id, salary)
        {
        }

        public override void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}, Employee Type: Part Time");
        }

        public override void TakeBreak()
        {
            Console.WriteLine("Taking a short break...");
        }

        public override void Work()
        {
            Console.WriteLine("Working part time...");
        }
    }
}
