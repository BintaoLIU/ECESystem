using System;

namespace ECEClasses
{
    public class clsStudent
    {

        private long PhoneNumber;
        private string StudentsName;
        private int PostCodes;
        private int StudentNumber;

        public string StudentName { get; set; }
        public long PhoneNum { get; set; }
        public int PostCode { get; set; }
        public int StudentNum { get; set; }

        public bool Find(int studentNo)
        {
            throw new NotImplementedException();
        }
    }
}