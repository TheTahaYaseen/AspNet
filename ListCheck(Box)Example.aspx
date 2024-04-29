<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCheck(Box)Example.aspx.cs" Inherits="Asp.Net.ListCheck_Box_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBoxList ID="CheckboxList" runat="server" OnSelectedIndexChanged="CheckboxList_SelectedIndexChanged">
        </asp:CheckBoxList>
        <div>
        </div>
        <asp:ListBox ID="Listbox" runat="server"></asp:ListBox>
        <div>
        </div>
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
