<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LiteralControlExample.aspx.cs" Inherits="Asp.Net.LiteralControlExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Label ID="LabelControl" runat="server" Text="Label"></asp:Label>
        <asp:Literal ID="LiteralControl" runat="server"></asp:Literal>
    </form>
</body>
</html>
