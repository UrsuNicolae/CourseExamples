namespace Exemple.EncapsulationAndAbstraction.EmployeeManagement
{
    public class EmployeeManger
    {
        private List<Employee> _employees;

        public EmployeeManger()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void DisplayAllEmployees()
        {
            foreach (var employee in _employees)
            {
                employee.DisplayEmployeeInfo();
            }
        }
    }
}
