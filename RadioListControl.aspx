<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioListControl.aspx.cs" Inherits="Asp.Net.RadioListControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioList" runat="server" OnSelectedIndexChanged="RadioList_SelectedIndexChanged">
            </asp:RadioButtonList>
            <asp:Button ID="FetchButton" runat="server" Text="Button" OnClick="FetchButton_Click" style="height: 26px" />
        </div>
        <asp:Button ID="ClearSelection" runat="server" Text="Button" OnClick="ClearSelection_Click" />
    </form>
</body>
</html>
