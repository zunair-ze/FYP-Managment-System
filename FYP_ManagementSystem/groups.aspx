<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="groups.aspx.cs" Inherits="FYP_ManagementSystem.groups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Groups</title>
    <link rel="stylesheet" href="StyleSheet5.css" />
</head>
<body>
    <header>
    <h2><b>FYP Management System</b></h2>
    </header>
    <div class="container">
        <span style="background-color:darkgrey; padding:5px;"><b>Add Group</b></span>
        <form id="form2" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" /> <br />
            <table>
                <tr>
                    <th colspan="2">Select Students:</th>
                </tr>
                <tr>
                    <td>First:</td>
                    <td><asp:DropDownList ID="ddlCountry" runat="server" Height="16px" Width="120px" /></td>
                </tr>
                <tr>
                    <td>Second:</td>
                    <td><asp:DropDownList ID="name2" DataTextField="name" DataValueField="name" runat="server" Height="16px" Width="120px"></asp:DropDownList> <br /></td>
                </tr>
                <tr>
                    <td>Project:</td>
                    <td><asp:DropDownList ID="project" DataTextField="name" DataValueField="name" runat="server" Height="16px" Width="120px"></asp:DropDownList> <br /></td>
                </tr>
                <tr>
                    <td>Advisor:</td>
                    <td><asp:DropDownList ID="advisor" DataTextField="name" DataValueField="name" runat="server" Height="16px" Width="120px"></asp:DropDownList> <br /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="add" runat="server" Text="Add Group" OnClick="add_Click" /></td>
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
