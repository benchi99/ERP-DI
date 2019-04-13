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
    public class VisorTests
    {
        [TestMethod()]
        public void devolverTodasLasFechasTest()
        {
            List<string> fechas = Visor.devolverTodasLasFechas();

            Assert.AreEqual(fechas[0], "1996-07-04 00:00:00.000");
        }
    }
}