<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="FYP_ManagementSystem.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Result Form</h2>
        </header>
        <asp:GridView ID="grid1" runat="server" OnSelectedIndexChanged="result_SelectedIndexChanged"></asp:GridView>
    </form>
</body>
</html>
