<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="project.aspx.cs" Inherits="FYP_ManagementSystem.project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Project</title>
    <link rel="stylesheet" href="StyleSheet2.css" />
</head>
<body>
    <header>
    <h2><b>FYP Management System</b></h2>
    </header>
    <div class="container">
        <span style="background-color:darkgrey; padding:5px;"><b>Add Project Section</b></span>
        <form id="form1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" /> <br />
            <span>Tilte: </span>
            <asp:TextBox ID="name" runat="server" Width="255px"></asp:TextBox> <br />
            <asp:TextBox ID="des" TextMode="multiline" Columns="35" Rows="10" runat="server" Text="description"></asp:TextBox> <br />
            <asp:Button ID="add" runat="server" Text="Add Project" OnClick="add_Click" />
        </form>
    </div>
    <footer>
        <span>Software Engineerings' Project</span>
        <span>Computer Science Department, UET Lahore</span>
    </footer>
</body>
</html>
