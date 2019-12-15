<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="FYP_ManagementSystem.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2 style="text-align:center">Add Students or Advisors</h2>
        </header>
        <asp:DropDownList ID="type" runat="server">
            <asp:ListItem Value="">select</asp:ListItem>
            <asp:ListItem Value="student">Student</asp:ListItem>
            <asp:ListItem Value="advisor">Advisor</asp:ListItem>
        </asp:DropDownList>  <br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="fname" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="reg_no" runat="server"></asp:TextBox> <br />
        <asp:Button ID="btn1" runat="server" Text="Add" OnClick="btn1_Click" />
    </form>
</body>
</html>
