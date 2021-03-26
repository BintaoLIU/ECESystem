using System;

namespace ECEClasses
{
    public class clsStudent
    {

        private int PhoneNumber;
        private string StudentsName;
        private int PostCodes;
        private int StudentNumber;

        public string StudentName
        {
            get
            {
                return StudentsName;
            }
            set
            {
                StudentsName = value;
            }
        }
        public int PhoneNum
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }
        public int PostCode
        {
            get
            {
                return PostCodes;
            }
            set
            {
                PostCodes = value;
            }
        }
        public int StudentNum
        {
            get
            {
                return StudentNumber;
            }
            set
            {
                StudentNumber = value;
            }
        }

        public bool Find(int StudentNum)
        {
            StudentNumber = 2617175;
            PhoneNumber = 12345678;
            PostCodes = 518000;
            StudentsName = "LeBron";

            return true;
        }

    }
}