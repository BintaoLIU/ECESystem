<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnSubject.aspx.cs" Inherits="AnSubject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="lblSubjects" runat="server" Text="Subjects" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSubjects" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblTeacher" runat="server" Text="Teacher No" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtTeacher" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblData" runat="server"  Text="Data Added" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtData" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSalary" runat="server" Text="Salary" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSalary" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblType" runat="server" Text="Subjects Type" Width="145px"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlType" runat="server" style="z-index: 1; " OnSelectedIndexChanged="ddlType_SelectedIndexChanged"></asp:DropDownList>
            <br />
            &nbsp;<br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click"  />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click"  />
        </div>
    </form>
</body>
</html>

