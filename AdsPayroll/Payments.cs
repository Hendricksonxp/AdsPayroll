using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AdsPayroll
{
    public class Payments
    {
        private List<Payment> payments = new List<Payment>();
        public Payment PaymentFor(string payDate)
        {
             return payments.Find(aPayment => aPayment.GetPayDate() == payDate);
        }

        public Payment GetCurrent()
        {
            return payments.Last();
        }

        public void Add(Payment aPayment)
        {
            payments.Add(aPayment); 
        }
    }
}