<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="evaluation.aspx.cs" Inherits="FYP_ManagementSystem.evaluation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Evaluation Form</h2>
        </header>
        <asp:DropDownList ID="g" DataTextField="students" DataValueField="students" runat="server"></asp:DropDownList> <br />
        <asp:TextBox ID="total" runat="server"></asp:TextBox>
        <asp:TextBox ID="obtained" runat="server"></asp:TextBox> <br />
        <asp:Button ID="add" runat="server" Text="Button" OnClick="add_Click" />
    </form>
</body>
</html>
