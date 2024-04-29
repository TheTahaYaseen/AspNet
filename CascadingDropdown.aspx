<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDropdown.aspx.cs" Inherits="Asp.Net.CascadingDropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ContinentsList" runat="server" OnSelectedIndexChanged="ContinentsList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="CountriesList" runat="server" OnSelectedIndexChanged="CountriesList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="CitiesList" runat="server" OnSelectedIndexChanged="CitiesList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
    </form>
</body>
</html>
