<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControlEvents.aspx.cs" Inherits="Asp.Net.ServerControlEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="ControlEvents" runat="server">
        <div>

            <asp:TextBox ID="CachedEventTextbox" runat="server" OnTextChanged="CachedEventTextbox_TextChanged"></asp:TextBox>

            <asp:Button ID="PostBackButton" runat="server" OnClick="PostBackButton_Click" Text="PostBack Event" Width="138px" />

        </div>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="CachedEventTextbox" ErrorMessage="*Required"></asp:RequiredFieldValidator>
        </p>
    </form>
</body>
</html>
