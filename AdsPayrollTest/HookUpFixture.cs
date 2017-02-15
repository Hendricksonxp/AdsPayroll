using System;
using AdsPayroll;

namespace AdsPayrollTest
{
    public class HookUpFixture 
    {
        public String FirstName;
        public String LastName;

        public String FullName()
        {
            NameMerger merger = new NameMerger();
            return merger.Merge(FirstName, LastName);
        }
    }
}
