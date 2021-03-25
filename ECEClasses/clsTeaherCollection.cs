using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsTeacherCollection
    {
        //private data member for the allCountes list
        private List<clsSubjectTeacher> mAllTeachers = new List<clsSubjectTeacher>();

        public clsTeacherCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblSubjectsType_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the SubjectTeacher class
                clsSubjectTeacher ATeacher = new clsSubjectTeacher();
                //get the TaughtSubjects
                ATeacher.TaughtSubjects = DB.DataTable.Rows[Index]["TaughtSubjects"].ToString();
                //get the primary key
                ATeacher.SubTeacherNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SubTeacherNo"]);
                //add the Teacher to the private data member
                mAllTeachers.Add(ATeacher);
                //increment the index
                Index++;
            }
        }

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllTeachers.Count;
            }
            //setter accepts data from other objects
            set
            {
                //we will look at this in a moment!
            }
        }
        public List<clsSubjectTeacher> AllSubTeachers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllTeachers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllTeachers = value;
            }
        }
    }
}