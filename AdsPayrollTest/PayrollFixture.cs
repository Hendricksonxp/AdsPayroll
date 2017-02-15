using AdsPayroll;

namespace AdsPayrollTest
{
    public class PayrollFixture
    {
        public static Payroll payroll;

        public string id;
        public string name;
        public string payType;
        public string rate;

        public bool initializePayroll()
        {
            payroll = new Payroll();
            return true;
        }

        public bool add()
        {
            var dollarRate = Dollars.Parse(rate);
            var newEmployee = new Employee(id, name, payType, dollarRate);
            return true;
        }

        public int pay()
        {
            payroll.Pay("02/01/2017");
            return payroll.PayCount();
        }



    }
}