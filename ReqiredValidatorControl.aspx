<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReqiredValidatorControl.aspx.cs" Inherits="Asp.Net.ReqiredValidatorControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        function IsEven(source, args) {
            if (args.Value == 0) {
                args.IsValid = false;
            }
            else {
                if (args.Value % 2 == 0) {
                    args.IsValid = true;
                }
                else {
                    args.IsValid = false;
                }
            }
        }
    </script>
</head>
<body>
    <form id="MainForm" runat="server">

        <asp:Label ID="NameLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="NameInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Label ID="EmailLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="EmailInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="EmailRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server"></asp:RegularExpressionValidator>
        <br /><br />

        <asp:Label ID="AgeLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="AgeInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="AgeRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="AgeRangeValidator" runat="server"></asp:RangeValidator>
        <asp:CompareValidator ID="AgeCompareValidator" runat="server"></asp:CompareValidator>
        <asp:CustomValidator ID="EvenAgeCustomValidator" runat="server" OnServerValidate="EvenAgeCustomValidator_ServerValidate"></asp:CustomValidator>
        <br /><br />

        <asp:Label ID="DateLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="DateInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="DateRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="DateRangeValidator" runat="server"></asp:RangeValidator>
        <asp:CompareValidator ID="DateCompareValidator" runat="server"></asp:CompareValidator>
        <br /><br />

        <asp:Label ID="PasswordLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="PasswordInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Label ID="ConfirmPasswordLabel" runat="server"></asp:Label>
        <br />

        <asp:TextBox ID="ConfirmPasswordInput" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ConfirmPasswordRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="ConfirmPasswordCompareValidator" runat="server"></asp:CompareValidator>
        <br /><br />

        <asp:Label ID="GenderLabel" runat="server"></asp:Label>
        <br />

        <asp:DropDownList ID="GenderInput" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="GenderRequiredValidator" runat="server"></asp:RequiredFieldValidator>
        <br /><br />

        <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" />
        <br /><br />        

        <asp:Label ID="StatusLabel" runat="server"></asp:Label>
        <br /><br />        

        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
        
    </form>
</body>
</html>
