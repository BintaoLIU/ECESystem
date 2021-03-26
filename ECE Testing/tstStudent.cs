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
        public void PhoneNumOk()
        {
            clsStudent AStudent = new clsStudent();
            int APhoneNum = 12345678;
            AStudent.PhoneNum = APhoneNum;
            Assert.AreEqual(AStudent.PhoneNum, APhoneNum);
        }

        [TestMethod]
        public void StudentNumOk()
        {
            clsStudent AStudent = new clsStudent();
            int AStudentNum = 2617175;
            AStudent.StudentNum = AStudentNum;
            Assert.AreEqual(AStudent.StudentNum, AStudentNum);
        }

        public void PostCodeOk()
        {
            clsStudent AStudent = new clsStudent();
            int APostCode = 518000;
            AStudent.PostCode = APostCode;
            Assert.AreEqual(AStudent.PostCode, APostCode);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsStudent AStudent = new clsStudent();
            Boolean Found = false;
            int StudentNum = 2617175;
            Found = AStudent.Find(StudentNum);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStudentNumFound()
        {
            clsStudent AStudent = new clsStudent();
            Boolean Found = false;
            Boolean Ok = true;
            int StudentNo = 2617175;
            Found = AStudent.Find(StudentNo);
            if (AStudent.StudentNum != 2617175)
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestPhoneNumFound()
        {
            clsStudent AStudent = new clsStudent();
            Boolean Found = false;
            Boolean Ok = true;
            int PhoneNum = 12345678;
            Found = AStudent.Find(PhoneNum);
            if (AStudent.PhoneNum != 12345678)
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

    }

}
