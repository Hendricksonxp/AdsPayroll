using AdsPayroll;

namespace AdsPayrollTest
{
    public class PayrollFixture
    {
        private static Payroll payroll;

        public string id;
        public string employeeName;
        public string payType;
        public string rate;
        public string name;

        private Employee currentEmployee;
        private Payment currentPayment;

        public bool initializePayroll()
        {
            payroll = new Payroll();
            return true;
        }

        public bool add()
        {
            var dollarRate = Dollars.Parse(rate);
            var newEmployee = new Employee(id, employeeName, payType, dollarRate);
            payroll.AddEmployee(newEmployee);
            return true;
        }

        public int pay()
        {
            payroll.Pay("02/01/2017");
            return payroll.PayCount();
        }

        public string Name()
        {
            currentEmployee = payroll.GetEmployee(id);
            currentPayment = currentEmployee.GetCurrentPayment();
            return currentEmployee.GetName();
        }

        public string grossPay()
        {
            return currentPayment.GetGrossPay().ToCleanString();
        }

        public string federalTax()
        {
            return currentPayment.GetFederalTax().ToCleanString();
        }

        public string netPay()
        {
            return currentPayment.GetNetPay().ToCleanString();
        }
    }
}