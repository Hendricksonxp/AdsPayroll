using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
