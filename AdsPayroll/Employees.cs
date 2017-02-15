using System.Collections.Generic;

namespace AdsPayroll
{
    public class Employees
    {
        Dictionary<string, Employee> collection = new Dictionary<string, Employee>();


        public void Add(Employee employee)
        {
            collection.Add(employee.GetId(), employee);
        }
    }
}