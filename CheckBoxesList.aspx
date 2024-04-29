<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxesList.aspx.cs" Inherits="Asp.Net.CheckBoxesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="SelectAllButton" runat="server" Text="Button" OnClick="SelectAllButton_Click" />
            <asp:Button ID="DeselectAllButton" runat="server" Text="Button" OnClick="DeselectAllButton_Click" />
            <asp:CheckBoxList ID="CheckboxList" runat="server">
            </asp:CheckBoxList>
        </div>
        <asp:Button ID="ConfirmButton" runat="server" OnClick="ConfirmButton_Click" Text="Button" />
    </form>
</body>
</html>
