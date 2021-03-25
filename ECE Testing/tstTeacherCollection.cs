using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECE_Testing
{
    [TestClass]
    public class tstTeacherCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTeacherCollection AllTeachers = new clsTeacherCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTeachers);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsTeacherCollection AllTeachers = new clsTeacherCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 7;
            //assign the data to the property
            AllTeachers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllTeachers.Count, SomeCount);
        }

        [TestMethod]
        public void AllCountiesOK()
        {
            //create an instance of the class we want to create
            clsTeacherCollection Teachers = new clsTeacherCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSubjectTeacher> TestList = new List<clsSubjectTeacher>();
            //add an item to the list
            //create the item of test data
            clsSubjectTeacher TestItem = new clsSubjectTeacher();
            //set its properties
            TestItem.SubTeacherNo = 1;
            TestItem.TaughtSubjects = "English";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Teachers.AllSubTeachers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Teachers.AllSubTeachers, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsTeacherCollection Teachers = new clsTeacherCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSubjectTeacher> TestList = new List<clsSubjectTeacher>();
            //add an item to the list
            //create the item of test data
            clsSubjectTeacher TestItem = new clsSubjectTeacher();
            //set its properties
            TestItem.SubTeacherNo = 1;
            TestItem.TaughtSubjects = "Liberal Arts";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Teachers.AllSubTeachers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Teachers.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoTeachersPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsTeacherCollection Teachers = new clsTeacherCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Teachers.Count,2);
        //}
    }
}

