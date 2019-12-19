<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FYP_ManagementSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styleSheet.css" />
    <title>Home</title>
</head>
<body>
    <header>
    <h2><b>FYP Management System</b></h2>
    </header>
    <div class="container">
        <p>Welcome to <b>Final Year Management System</b></p>
        <p>You can perform following actions:</p><br />
        <span><a href="add.aspx" class="s1"><b>Add Students/Advisor</b></a></span> <br /><br />
        <span><a href="project.aspx" class="s2"><b>Add Projects</b></a></span> <br /><br />
        <span><a href="groups.aspx" class="s3"><b>Add Group</b></a></span> <br /><br />
        <span><a href="evaluation.aspx" class="s4"><b>Evaluation</b></a></span> <br /><br />
        <span><a href="result.aspx" class="s5"><b>Result Page</b></a></span>
    </div>
    <footer>
        <span>Software Engineerings' Project</span>
        <span>Computer Science Department, UET Lahore</span>
    </footer>
</body>
</html>
