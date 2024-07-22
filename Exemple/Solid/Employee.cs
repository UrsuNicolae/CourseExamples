namespace Exemple.Solid
{

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }


        public void CalculatePay()
        {
            // Logica pentru calcularea salariului
            Console.WriteLine($"Calculating pay for {Name}...");
        }


        public void Save()
        {
            // Logica pentru salvarea angajatului în baza de date
            Console.WriteLine($"Saving {Name} to the database...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "John", Salary = 50000 };
            employee.CalculatePay();
            employee.Save();
        }
    }
}
