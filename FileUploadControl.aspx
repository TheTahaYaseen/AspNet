<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadControl.aspx.cs" Inherits="Asp.Net.FileUploadControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
            <br />
            <br />

            <asp:FileUpload ID="FileInput" runat="server" />
            <asp:Button ID="UploadButton" runat="server" Text="Button" OnClick="UploadButton_Click" />
        </div>
    </form>
</body>
</html>
