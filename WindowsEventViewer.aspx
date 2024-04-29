<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WindowsEventViewer.aspx.cs" Inherits="Asp.Net.WindowsEventViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <asp:Label ID="EventLogName" runat="server" Text="Event Log Name"></asp:Label>
            <br />

            <asp:TextBox ID="EventLogNameInput" runat="server"></asp:TextBox>
            <br /><br />
            
            <asp:Label ID="EventLogSource" runat="server" Text="Event Log Source"></asp:Label>
            <br />

            <asp:TextBox ID="EventLogSourceInput" runat="server"></asp:TextBox>
            <br /><br />
            
            <asp:Button ID="ProceedButton" runat="server" Text="Proceed" OnClick="ProceedButton_Click" />
        </div>
    </form>
</body>
</html>
