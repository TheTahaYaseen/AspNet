<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseSubmitBehaviour.aspx.cs" Inherits="Asp.Net.UseSubmitBehaviour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:TextBox ID="WrittenInput" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ClearButton" runat="server" Text="Button" OnClick="ClearButton_Click" />
        <asp:Button ID="SubmitButton" runat="server" Text="Button" OnClick="SubmitButton_Click" />
        <br /><br />
        <asp:Label ID="WrittenLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
