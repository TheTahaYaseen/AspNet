<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buttons.aspx.cs" Inherits="Asp.Net.Buttons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />
            <asp:ImageButton ID="ImageButton" runat="server" OnClick="ImageButton_Click" />
            <asp:LinkButton ID="LinkButton" runat="server" OnClick="LinkButton_Click">LinkButton</asp:LinkButton>
        </div>
    </form>
</body>
</html>
