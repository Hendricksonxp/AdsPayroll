using System.Collections.Generic;

namespace AdsPayroll
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();


        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployee(string id)
        {
            return _employees.Find(anEmployee => anEmployee.GetId() == id);
        }

        public void Pay(Payroll payroll)
        {

            foreach (var employee in _employees)
            {
                payroll.PayEmployee(employee);
            }
        }
    }
}