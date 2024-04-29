<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckControl.aspx.cs" Inherits="Asp.Net.CheckControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="CheckControlForm" runat="server">
        <asp:CheckBox ID="WebDevCheck" runat="server" />
&nbsp;<asp:CheckBox ID="WebAppCheck" runat="server" OnCheckedChanged="WebAppCheck_CheckedChanged" />
        <asp:Button ID="TellButton" runat="server" OnClick="TellButton_Click" Text="Button" />
    </form>
</body>
</html>
