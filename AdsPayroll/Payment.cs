namespace AdsPayroll
{
    public class Payment
    {
        private Dollars grossPay;
        private Dollars netPay;
        private Dollars basePay;
        private Dollars federalTax;
        private string id;
        private string name;
        private string payDate;

        public Payment(string date, string id, string name)
        {
            this.payDate = date;
            this.id = id;
            this.name = name;
        }

        public Dollars GetNetPay()
        {
            return netPay;
        }

        public Dollars GetGrossPay()
        {
            return grossPay;
        }

        public Dollars GetFederalTax()
        {
            return federalTax;
        }

        public void SetBasePay(Dollars amount)
        {
            basePay = amount;
        }

        public void SetGrossPay(Dollars amount)
        {
            grossPay = amount;
        }

        public void SetFederalTax(Dollars amount)
        {
            federalTax = amount;
        }

        public void SetNetPay(Dollars amount)
        {
            netPay = amount;
        }

        public string GetPayDate()
        {
            return payDate;
        }
    }
}