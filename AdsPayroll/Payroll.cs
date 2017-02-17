﻿using System.Collections.Generic;

namespace AdsPayroll
{
    public class Payroll
    {
        Employees employees = new Employees();
        private string payDate;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void Pay(string payDate)
        {
            {
                this.payDate = payDate;
                employees.Pay(this);
            }
        
        }

        public int PayCount()
        {
            return -1;
        }

        public Employee GetEmployee(string id)
        {
            return employees.GetEmployee(id);
        }

        public void PayEmployee(Employee employee)
        {
            Dollars basePay = Dollars.Zero();
            var grossPay = Dollars.Zero();
            var federalTax = Dollars.Zero();
            var netPay = Dollars.Zero();

            basePay += employee.GetPayRate();
            grossPay += basePay;
            federalTax = grossPay*FederalTaxRate();
            netPay = grossPay - federalTax;

            var payment = new Payment(payDate, employee.GetId(), employee.GetName());
            payment.SetBasePay(basePay);
            payment.SetGrossPay(grossPay);
            payment.SetFederalTax(federalTax);
            payment.SetNetPay(netPay);
            employee.AddPayment(payment);

        }

        private decimal FederalTaxRate()
        {
            return 0.25m;
        }
    }
}