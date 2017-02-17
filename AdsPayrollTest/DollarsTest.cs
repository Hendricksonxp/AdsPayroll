using AdsPayroll;
using NUnit.Framework;

namespace AdsPayrollTest
{
    [TestFixture]
    class DollarsTest
    {
        [Test]
        public void TestAddition()
        {
            var fiveDollars = Dollars.Parse("5.00");
            var twoDollars = Dollars.Parse("2.00");
            var threeDollars = Dollars.Parse("3.00");
            var result = threeDollars + twoDollars;

            Assert.AreEqual("5.00", result.ToCleanString());
            Assert.AreEqual(fiveDollars,result);
        }

        [Test]
        public void TestSubtraction()
        {
            var fiveDollars = Dollars.Parse("5.00");
            var twoDollars = Dollars.Parse("2.00");
            var threeDollars = Dollars.Parse("3.00");
            var result = fiveDollars - twoDollars;

            Assert.AreEqual("3.00", result.ToCleanString());
            Assert.AreEqual(threeDollars,result);
        }

        [Test]
        public void TestMultiplicationDecimal()
        {
            var tenDollars = Dollars.Parse("10.00");
            var twoFifty = Dollars.Parse("2.50");
            Assert.AreEqual(twoFifty, tenDollars * 0.25m);
        }

        [Test]
        public void TestMultiplicationInt()
        {
            var tenDollars = Dollars.Parse("10.00");
            var twoFifty = Dollars.Parse("2.50");
            Assert.AreEqual(tenDollars, twoFifty * 4);
        }

        [Test]
        public void TestDollarCreation()
        {
            var dollars = new Dollars(10.00m);
            Assert.AreEqual("10.00", dollars.ToCleanString());
        }

        [Test]
        public void TestDollarParse()
        {
            var dollars = Dollars.Parse("5.00");
            Assert.AreEqual("5.00", dollars.ToCleanString());
        }

        [Test]
        public void TestDollarEquals()
        {
            var dollar1 = Dollars.Parse("5.00");
            var dollar2 = Dollars.Parse("5.00");
            Assert.IsTrue(dollar1.Equals(dollar2));
        }

        [Test]
        public void TestDollarGreaterThan()
        {
            var dollar1 = Dollars.Parse("1.00");
            var dollar2 = Dollars.Parse("2.00");
            Assert.IsTrue(dollar2 > dollar1 );
            Assert.IsFalse(dollar1 > dollar2);
        }

        [Test]
        public void PlusEqualsTest()
        {
            var dollar1 = Dollars.Parse("1.00");
            var dollar2 = Dollars.Parse("2.00");


            dollar2 += dollar1;
            Assert.AreEqual("3.00", dollar2.ToCleanString());
        }
    }
}
