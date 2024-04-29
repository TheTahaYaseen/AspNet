<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="Asp.Net.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label" runat="server" Text="Update Name"></asp:Label>
            <br />
            <br />
            <asp:HiddenField ID="HiddenEmployeeId" runat="server" />
            <asp:TextBox ID="NameInput" runat="server"></asp:TextBox>
            <br />
            <br />            
            <asp:TextBox ID="QuoteInput" runat="server"></asp:TextBox>
            <br />
            <br />            
            <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
            <asp:Button ID="LoadButton" runat="server" Text="Load" OnClick="LoadButton_Click" />
        </div>
    </form>
</body>
</html>
