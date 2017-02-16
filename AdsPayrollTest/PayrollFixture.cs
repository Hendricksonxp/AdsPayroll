using AdsPayroll;

namespace AdsPayrollTest
{
    public class PayrollFixture
    {
        public static Payroll payroll;

        public string id;
        public string employeeName;
        public string payType;
        public string rate;
        private Employee currentEmployee;

        public bool initializePayroll()
        {
            payroll = new Payroll();
            return true;
        }

        public bool add()
        {
            var dollarRate = Dollars.Parse(rate);
            var newEmployee = new Employee(id, employeeName, payType, dollarRate);
            return true;
        }

        public int pay()
        {
            payroll.Pay("02/01/2017");
            return payroll.PayCount();
        }

        public string name()
        {
            currentEmployee = payroll.GetEmployee(id);
            return currentEmployee.GetName();
        }

        public string grossPay()
        {
            return currentEmployee.GetCurrentPayment().GetGrossPay().toCleanString();
        }

        public string federalTax()
        {
            return currentEmmployee.GetFederalTax().toCleanString();
        }

        public string netPay()
        {
            return currentEmployee.GetNetPay().toCleanString();
        }
    }
}