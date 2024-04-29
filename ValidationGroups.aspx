<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationGroups.aspx.cs" Inherits="Asp.Net.ValidationGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        
        <asp:Label ID="RegisterLabel" runat="server"></asp:Label>
        <br /><br />
        
        <asp:Label ID="RegisterNameLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="RegisterNameInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RegisterNameRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Label ID="RegisterEmailLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="RegisterEmailInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RegisterEmailRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegisterEmailRegularExpressionValidator" runat="server"></asp:RegularExpressionValidator>
        <br /><br />

        <asp:Label ID="RegisterPasswordLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="RegisterPasswordInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RegisterPasswordRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Label ID="RegisterConfirmPasswordLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="RegisterConfirmPasswordInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RegisterConfirmPasswordRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="RegisterConfirmPasswordCompareValidator" runat="server"></asp:CompareValidator>
        <br /><br />

        <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" />
        <br /><br />        

        <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" />
        <br /><br />        

        <asp:Label ID="RegistrationStatusLabel" runat="server"></asp:Label>
        <br /><br />        

        <asp:ValidationSummary ID="RegistrationValidationSummary" runat="server" />

        <hr />
        
        <asp:Label ID="LoginLabel" runat="server"></asp:Label>
        <br /><br />

        <asp:Label ID="LoginEmailLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="LoginEmailInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="LoginEmailRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="LoginEmailRegularExpressionValidator" runat="server"></asp:RegularExpressionValidator>
        <br /><br />

        <asp:Label ID="LoginPasswordLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="LoginPasswordInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="LoginPasswordRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" />
        <br /><br />        

        <asp:Label ID="LoginStatusLabel" runat="server"></asp:Label>
        <br /><br />        

        <asp:ValidationSummary ID="LoginValidationSummary" runat="server" />
    </form>

</body>
</html>
