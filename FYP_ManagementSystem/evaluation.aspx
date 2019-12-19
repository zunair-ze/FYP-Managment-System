<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="evaluation.aspx.cs" Inherits="FYP_ManagementSystem.evaluation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Evaluation</title>
    <link rel="stylesheet" href="StyleSheet3.css" />
</head>
<body>
    <header>
    <h2><b>FYP Management System</b></h2>
    </header>
    <div class="container">
        <span style="background-color:darkgrey; padding:5px;"><b>Evaluation Section</b></span>
        <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" /> <br />
            <asp:DropDownList ID="g" DataTextField="students" DataValueField="students" runat="server"></asp:DropDownList> <br /> <br />
            <span><b>Enter Marks:</b></span> <br />
            <div class="input">
            Total: <asp:TextBox ID="total" runat="server"></asp:TextBox>
            Obtained: <asp:TextBox ID="obtained" runat="server"></asp:TextBox> <br />
            </div>
            <asp:Button ID="add" runat="server" Text="Enter Record" OnClick="add_Click" />
        </form>
    </div>
    <footer>
        <span>Software Engineerings' Project</span>
        <span>Computer Science Department, UET Lahore</span>
    </footer>
</body>
</html>
