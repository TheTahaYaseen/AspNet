<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelControl.aspx.cs" Inherits="Asp.Net.PanelControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        
        <asp:DropDownList ID="InterfaceSelection" runat="server" OnSelectedIndexChanged="InterfaceSelection_SelectedIndexChanged">
        </asp:DropDownList>

        <br /><br />

        <asp:Panel ID="AdminPanel" runat="server">
            <asp:Label ID="AdminInterfaceLabel" runat="server"></asp:Label>
        </asp:Panel>

        <asp:Panel ID="UserPanel" runat="server">
            <asp:Label ID="UserInterfaceLabel" runat="server"></asp:Label>        
        </asp:Panel>

    </form>
</body>
</html>
