<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioCheckControl.aspx.cs" Inherits="Asp.Net.RadioCheckControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="RadioCheckControlForm" runat="server">
        <div>

            <asp:RadioButton ID="MaleRadioButton" runat="server" Text="Male" />
            <asp:RadioButton ID="FemaleRadioButton" runat="server" OnCheckedChanged="FemaleRadioButton_CheckedChanged" Text="Female" />
            <asp:Button ID="ChooseButton" runat="server" OnClick="ChooseButton_Click" Text="Choose" />

        </div>
    </form>
</body>
</html>
