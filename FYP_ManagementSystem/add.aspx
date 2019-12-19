<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="FYP_ManagementSystem.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Student/Advisor</title>
    <link rel="stylesheet" href="StyleSheet4.css" />
</head>
<body>
    <header>
    <h2><b>FYP Management System</b></h2>
    </header>
    <div class="container">
        <span style="background-color:darkgrey; padding:5px;"><b>Add Students or Advisors</b></span>
        <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" /> <br />
            <table>
                <tr>
                    <td colspan="2">
                        <asp:DropDownList ID="type" runat="server" AutoPostBack="true" OnSelectedIndexChanged="list_SelectedIndexChanged">
                            <asp:ListItem Value="no" Selected="True">Select Category</asp:ListItem>
                            <asp:ListItem Value="student" Text="Student"></asp:ListItem>
                            <asp:ListItem Value="advisor">Advisor</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Fathers Name:</td>
                    <td><asp:TextBox ID="fname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Registration No:</td>
                    <td><asp:TextBox ID="reg_no"  runat="server" AutoPostBack="true"> </asp:TextBox></td>
                </tr>
                <tr>
                    <td>Designation</td>
                    <td><asp:TextBox ID="des"  runat="server" AutoPostBack="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="btn1" runat="server" Text="Add Person" OnClick="btn1_Click" /></td>
                </tr>
            </table>
        </form>
    </div>
    <footer>
        <span>Software Engineerings' Project</span>
        <span>Computer Science Department, UET Lahore</span>
    </footer>
</body>
</html>
