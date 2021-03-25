using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ATeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the class library
        clsSubjectTeacher ATeacher = new clsSubjectTeacher();
        //declare a variable to store any error messages
        string Error;
        //declare a variable to capture user input from the page
        string SubjectsType, TeacherNo, DataAdded, Salary;
        //read in the date from the interface
        SubjectsType = txtSubjects.Text;
        TeacherNo = txtTeacher.Text;
        DataAdded = txtData.Text;
        Salary = txtSalary.Text;
        //validate the data using the classes validation method
        Error = ATeacher.Valid(SubjectsType, TeacherNo, DataAdded, Salary);
        //display the error message if there is one
        lblError.Text = Error;
    }


}