<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextControl.aspx.cs" Inherits="Asp.Net.TextControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="TextControlForm" runat="server">
        <asp:TextBox ID="TextBox" runat="server" OnTextChanged="TextBox_TextChanged"></asp:TextBox>
        <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
        <asp:TextBox ID="MultilineBox" runat="server"></asp:TextBox>
        <asp:Button ID="Check" runat="server" Text="Check" />
        <div>

        </div>
    </form>
</body>
</html>
