using System;
using ECEClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECE_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
    }
}
