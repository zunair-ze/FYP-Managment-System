<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="groups.aspx.cs" Inherits="FYP_ManagementSystem.groups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h2>Add Group</h2>
        </header>
        <asp:DropDownList ID="name1" DataTextField="name" DataValueField="name" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="name2" DataTextField="name" DataValueField="name" runat="server"></asp:DropDownList> <br />
        <asp:DropDownList ID="project" DataTextField="name" DataValueField="name" runat="server"></asp:DropDownList> <br />
        <asp:DropDownList ID="advisor" DataTextField="name" DataValueField="name" runat="server"></asp:DropDownList> <br />
        <asp:Button ID="add" runat="server" Text="Button" OnClick="add_Click" />
    </form>
</body>
</html>
