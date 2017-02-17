using System;
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

        public Employee GetEmployee(string id)
        {
            return collection[id];
        }

        public void Pay(Payroll payroll)
        {

            var values = collection.Values;
            foreach (var employee in values)
            {
                payroll.PayEmployee(employee);
            }
        }
    }
}