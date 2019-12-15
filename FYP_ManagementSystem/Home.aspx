<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FYP_ManagementSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2 style="text-align:center;">FYP Management System</h2>
        </header>
        <ul>
            <a href="add.aspx"><li>Add Students/Advisor</li></a>
            <a href="project.aspx"><li>Add Projects</li></a>
            <a href="groups.aspx"><li>Add Group</li></a>
            <a href="evaluation.aspx"><li>Evaluation</li></a>
            <a href="result.aspx"><li>Result Page</li></a>
        </ul>
    </form>
</body>
</html>
