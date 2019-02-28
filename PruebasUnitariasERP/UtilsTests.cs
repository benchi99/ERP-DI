using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void esDniValidoTest()
        {
            Assert.IsTrue(Utils.esDniValido("29622752V"));
        }
    }
}