using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdsPayroll;

namespace AdsPayrollTest
{
    public class EmployeeFixture
    {
        public static EmployeesAll emp ;

        public Boolean InitializeEmployees()
        {
            try
            {
                emp = new EmployeesAll();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int NumberofEmployees()
        {
            InitializeEmployees();
            return emp._Employees.Count();
        }
    }
}
