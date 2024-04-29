<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBoxControl.aspx.cs" Inherits="Asp.Net.ListBoxControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="Listbox" runat="server"></asp:ListBox>
            <asp:Button ID="ConfirmButton" runat="server" OnClick="ConfirmButton_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
