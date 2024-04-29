<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulletListControl.aspx.cs" Inherits="Asp.Net.BulletListControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletList" runat="server" OnClick="BulletList_Click">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
