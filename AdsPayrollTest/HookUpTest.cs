using System;
using NUnit.Framework;
using AdsPayroll;

namespace AdsPayrollTest
{
    public class HookUpTest
    {
    [Test]
        public void TestHookUp()
        {
            Assert.IsTrue(true);
        }

    [Test]
        public void NameMergeTest()
        {
            var nameMerger = new NameMerger();
            String result = nameMerger.Merge("Bob", "Johnson");
            Assert.GreaterOrEqual("Bob Johnson", result);
        }
        
    }
}
