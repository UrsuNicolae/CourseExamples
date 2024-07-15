/*namespace Exemple.ClassAndObject
{
    public class EmployeeManager
    {
        private List<Employee> employees;

        public EmployeeManager()
        {
            this.employees = new List<Employee>();
        }

        public void AddDeveloper(string nume, int age)
        {
            employees.Add(new Employee(nume, age, Job.Developer));
        }

        public void AddDesigner(string nume, int age)
        {
            employees.Add(new Employee(nume, age, Job.Designer));
        }

        public void AddAccountant(string nume, int age)
        {
            employees.Add(new Employee(nume, age, Job.Accountant));
        }

        public void AddIntern(string nume, int age)
        {
            employees.Add(new Employee(nume, age, Job.Intern));
        }

        public void DisplayEmployeesUnder25()
        {
            foreach(var employee in employees)
            {
                if(employee.Age <= 25)
                {
                    Console.Write(employee.Name + " ");
                }
            }
            Console.WriteLine();
        }

        public List<Employee> GetDevelopers()
        {
            return GetEmployees(Job.Developer);
        }

        public List<Employee> GetEmployees(Job job)
        {
            var employees = new List<Employee>();
            foreach(var employee in this.employees)
            {
                if(employee.Job == job)
                {
                    employees.Add(employee);
                }
            }
            return employees;
        }

    }

    public class Employee
    {
        public string Name;
        public int Age;
        public Job Job;

        public Employee(string nume, int age, Job job)
        {
            Name = nume;
            Age = age;
            Job = job;
        }
    }

    public enum Job
    {
        None = 0,
        Intern = 1,
        Accountant = 2,
        Developer = 3,
        Designer = 4
    }
}
*/