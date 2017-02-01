using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
