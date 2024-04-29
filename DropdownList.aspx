<%@ Page Trace="true" Language="C#" AutoEventWireup="true" ErrorPage="~/OpinionShow.aspx" CodeBehind="DropdownList.aspx.cs" Inherits="Asp.Net.DropdownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="SuitsList" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="EmployeesList" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="CountriesList" runat="server">
            </asp:DropDownList>
            <asp:Button ID="SelectButton" runat="server" OnClick="SelectButton_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
