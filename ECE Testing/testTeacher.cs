using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECE_Testing
{
    [TestClass]
    public class testTeacher
    {
        string TeacherNo = "12345";
        string SubjectsType = "English";
        string DataAdded = DateTime.Now.Date.ToString();
        string Salary = "3000";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //test to see that it exists
            Assert.IsNotNull(ATeacher);
        }

        [TestMethod]
        public void TaughtSubjectsPropertyOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create some test data to assign to the property
            string TestData = "English";
            //assign the data to the property
            ATeacher.TaughtSubjects = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATeacher.TaughtSubjects, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ATeacher.DataAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATeacher.DataAdded, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ATeacher.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATeacher.Salary, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ATeacher.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATeacher.Available, TestData);
        }

        [TestMethod]
        public void SubTeacherNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create some test data to assign to the property
            Int32 TestData = 12345;
            //assign the data to the property
            ATeacher.SubTeacherNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATeacher.SubTeacherNo, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMinBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "a";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "aa";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "0123456789012345678";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "01234567890123456789";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "012345678901234567890";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeMid()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "0123456789";
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubjectsTypeEtremeMax()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SubjectsType = "";
            //pad the string with characters
            SubjectsType = SubjectsType.PadRight(200, 'a');
            //invoke the method
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoInvalidData()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string TeacherNo = "This is not a data";
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoExtrmMin()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = -10000000;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = -1;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 0;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is Not OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 1;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 9999999;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMaxBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 10000000;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 10000001;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTeacherNoExtrameMax()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 100000000;
            string TeacherNo = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string DataAdded = "This is not a date";
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            TestDate = TestDate.AddDays(0);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            TestDate = TestDate.AddDays(0);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            string Salary = "This is not a data";
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = -10000;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = -1;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 0;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is Not OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 1;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 9999;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxBoundary()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 10000;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is OK i,e there should be an error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 10001;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            //create an instance of the class we want to create
            clsSubjectTeacher ATeacher = new clsSubjectTeacher();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to assign to the property
            Int32 TestData = 100000;
            string Salary = TestData.ToString();
            //assign the data to the property
            Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
            //test to see that the result is NOT OK i,e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
