<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListControls.aspx.cs" Inherits="Asp.Net.ListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:BulletedList ID="BulletList" runat="server">
        </asp:BulletedList>
        <br />
        <br />
        <asp:CheckBoxList ID="CheckboxList" runat="server">
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:DropDownList ID="DropdownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:ListBox ID="Listbox" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioList" runat="server">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="ConfirmButton" runat="server" Text="Button" OnClick="ConfirmButton_Click" />
    </form>
</body>
</html>
