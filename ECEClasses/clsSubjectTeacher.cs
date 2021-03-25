using System;

namespace ClassLibrary
{
    public class clsSubjectTeacher
    {
        public int SubTeacherNo { get; set; }
        public string TaughtSubjects { get; set; }
        public DateTime DataAdded { get; set; }
        public int Salary { get; set; }
        public bool Available { get; set; }

        public string Valid(string SubjectsType, string TeacherNo, string DataAdded, string Salary)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the subjects is more than 20 characters
            if (SubjectsType.Length > 20)
            {
                //return an error message
                Error = "The subjects name cannot have more than 20 characters";
            }
            if (SubjectsType.Length == 0)
            {
                //return an error message
                Error = "The subjects name may not be blank!";
            }

            try
            {
                Int32 TeacherNoTemp = Convert.ToInt32(TeacherNo);

                if (TeacherNoTemp < 0)
                {
                    Error = Error + "the TeacherNo cannot smaller than zero";
                }

                if (TeacherNoTemp == 0)
                {
                    Error = Error + "the TeacherNo cannot be zero";
                }

                if (TeacherNoTemp > 10000000)
                {
                    Error = Error + "the TeacherNo of teacher is reached the maximun number of items in the warehouse can holds";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid data";
            }

            try
            {
                DateTime DataAddedTemp = Convert.ToDateTime(DataAdded);

                if (DataAddedTemp < DateTime.Now.Date)
                {
                    Error = Error + "the Time cannot be in the past";
                }

                if (DataAddedTemp > DateTime.Now.Date)
                {
                    Error = Error + "the Time cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The data is invalid";
            }

            try
            {
                Int32 SalaryTemp = Convert.ToInt32(Salary);

                if (SalaryTemp < 0)
                {
                    Error = Error + "the Salary cannot smaller than zero";
                }

                if (SalaryTemp == 0)
                {
                    Error = Error + "the Salary cannot be zero";
                }

                if (SalaryTemp > 10000)
                {
                    Error = Error + "the Salary of teacher is reached the maximun number of items in the warehouse can holds";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid data";
            }
            return Error;
        }
    }
}