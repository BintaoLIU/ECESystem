using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnSubject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayTeachers();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("Default.aspx");
    }

    //function for populating the subjects type drop down list
    void DisplayTeachers()
    {
        //create an instance of the Teachers collection
        ClassLibrary.clsTeacherCollection Teachers = new ClassLibrary.clsTeacherCollection();
        //set the data source to the list of teachers in the collection
        ddlType.DataSource = Teachers.AllSubTeachers;
        //set the primary key
        ddlType.DataValueField = "SubTeacherNo";
        //set the data dield to display the teacher No
        ddlType.DataTextField = "TaughtSubjects";
        //bind the data to the list
        ddlType.DataBind();
    }

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}