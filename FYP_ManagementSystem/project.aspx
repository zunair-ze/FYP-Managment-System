<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="project.aspx.cs" Inherits="FYP_ManagementSystem.project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Add Projects</h2>
        </header>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:Button ID="add" runat="server" Text="Button" OnClick="add_Click" />
    </form>
</body>
</html>
