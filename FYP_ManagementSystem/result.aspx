<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="FYP_ManagementSystem.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result Page</title>
    <link rel="stylesheet" href="styleSheet1.css" />
</head>
<body>
    <header>
        <h2><b>Result Form</b></h2>
    </header>
    <div class="container">
        <form id="form1" runat="server">
        <span><b>The Evaluation's Result:</b></span>
        <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click1" />
        <asp:GridView ID="grid1" runat="server" OnSelectedIndexChanged="result_SelectedIndexChanged"></asp:GridView>
        <div class="output">
            <asp:Button ID="Button" runat="server" Text="Download" OnClick="Button1_Click" />
            <span>Click this button to download this table in pdf file</span>
        </div>
        </form>
    </div>
    <footer>
        <span>Software Engineerings' Project</span>
        <span>Computer Science Department, UET Lahore</span>
    </footer>
</body>
</html>
