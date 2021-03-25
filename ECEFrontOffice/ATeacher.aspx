<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ATeacher.aspx.cs" Inherits="ATeacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSubjects" runat="server" Text="Subjects"></asp:Label>
        &nbsp;&nbsp;
        &nbsp;<asp:TextBox ID="txtSubjects" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTeacher" runat="server" Text="Teacher No"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtTeacher" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblData" runat="server" Text="Data Added"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
&nbsp;
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Height="39px" OnClick="btnOK_Click" Text="OK" Width="48px" />
        </p>
    </form>
</body>
</html>
