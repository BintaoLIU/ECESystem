using System;
using ECEClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECE_Testing
{
    [TestClass]
    public class tstStudent
    {
        [TestMethod]
        public void IsInstanceOk()
        {
            //create an instance of the class we want create
            clsStudent AStudent = new clsStudent();

            //Test to see that it exists
            Assert.IsNotNull(AStudent);
        }

        [TestMethod]
        public void StudentNameOk()
        {
            clsStudent AStudent = new clsStudent();
            string AName = "LeBron";
            AStudent.StudentName = AName;
            Assert.AreEqual(AStudent.StudentName, AName);
        }

        [TestMethod]
        public void PhoneNoOk()
        {
            clsStudent AStudent = new clsStudent();
            Int64 AHomeNo = 075512345678;
            AStudent.HomeNo = AHomeNo;
            Assert.AreEqual(AStudent.HomeNo, AHomeNo);
        }

        public void PostCodeOk()
        {
            clsStudent AStudent = new clsStudent();
            Int32 APostCode = 518000;
            AStudent.PostCode = APostCode;
            Assert.AreEqual(AStudent.PostCode, APostCode);
        }
    }
}
