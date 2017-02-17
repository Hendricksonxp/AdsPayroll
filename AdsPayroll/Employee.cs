namespace AdsPayroll
{
    public class Employee
    {
        private string id;
        private string name;
        private string payType;
        private Dollars payRate;
        private Payments payments;

        public Employee(string id, string name, string payType, Dollars payRate)
        {
            this.id = id;
            this.name = name;
            this.payType = payType;
            this.payRate = payRate;
            payments = new Payments();
        }

        public string GetId()
        {
            return id;
        }


        public Payment GetPayment(string payDate)
        {
            return payments.PaymentFor(payDate);
        }

        public string GetName()
        {
            return name;
        }

        public Payment GetCurrentPayment()
        {
            return payments.GetCurrent();
        }

        public Dollars GetPayRate()
        {
            return payRate;
        }

        public Dollars GetFederalTax()
        {
            return GetCurrentPayment().GetFederalTax();
        }

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }
    }
}