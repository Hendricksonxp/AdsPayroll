using System;
using NUnit.Framework;
using AdsPayroll;
using Newtonsoft.Json.Bson;

namespace AdsPayrollTest
{
    public class PayrollTest
    {
        [Test]
        public void SalaryTest()
        {
            Payroll payroll = new Payroll();
            Dollars payrate = Dollars.Parse("4000.00");
            Employee carl = new Employee("1", "Carl","Salary", payrate);
            payroll.AddEmployee(carl);

            var payDate = "01/31/2017";
            payroll.Pay(payDate);
            var payment =  carl.GetPayment(payDate);
            Assert.AreEqual("1", carl.GetId());
            Assert.AreEqual("3,000.00", payment.GetNetPay().ToCleanString());
            Assert.AreEqual(1, payroll.PayCount());
            Assert.AreEqual("Carl", payroll.GetEmployee("1").GetName());
        }

    }
}