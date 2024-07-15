namespace Exemple.EncapsulationAndAbstraction.EmployeeManagement
{
    public abstract class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
        }

        public virtual void TakeBreak()
        {
            Console.WriteLine("Taking a break...");
        }

        public abstract void Work();
    }
}
