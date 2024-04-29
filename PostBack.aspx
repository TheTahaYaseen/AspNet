<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="Asp.Net.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="PostBackForm" runat="server">
        <div>

            <%--<asp:DropDownList ID="CitiesList" runat="server" OnSelectedIndexChanged="CitiesList_SelectedIndexChanged" EnableViewState="false">--%>
            <%--</asp:DropDownList>--%>

            <asp:DropDownList ID="CitiesList" runat="server" OnSelectedIndexChanged="CitiesList_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:Button ID="TellButton" runat="server" Text="Tell" />
        </div>
    </form>
</body>
</html>
