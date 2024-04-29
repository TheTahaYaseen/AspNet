<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewModal.aspx.cs" Inherits="Asp.Net.MultiViewModal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:MultiView ID="MultiViewEmployeeForm" runat="server">

            <asp:View ID="PersonalDetailsView" runat="server">
                <asp:Label ID="PersonalHeading" runat="server" Text="Enter personal details"></asp:Label>
                <br />
                <br />
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label>
                <br />
                <asp:TextBox ID="FirstNameInput" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"></asp:Label>
                <br />
                <asp:TextBox ID="LastNameInput" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:DropDownList ID="GenderInput" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="ProceedToContactButton" runat="server" Text="Proceed" OnClick="ProceedToContactButton_Click" />
            </asp:View>

            <asp:View ID="ContactDetailsView" runat="server">
                <asp:Label ID="ContactHeading" runat="server" Text="Enter contact details"></asp:Label>
                <br />
                <br />
                <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
                <br />
                <asp:TextBox ID="EmailInput" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="ContactLabel" runat="server" Text="Contact"></asp:Label>
                <br />
                <asp:TextBox ID="ContactInput" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ProceedToSummaryButton" runat="server" Text="Proceed" OnClick="ProceedToSummaryButton_Click" />
            </asp:View>

            <asp:View ID="DetailsSummaryView" runat="server">
                <asp:Label ID="SummaryFirstNameLabel" runat="server" Text="First Name"></asp:Label>
                <br />
                <asp:Label ID="SummaryFirstName" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="SummaryLastNameLabel" runat="server" Text="Last Name"></asp:Label>
                <br />
                <asp:Label ID="SummaryLastName" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="SummaryGenderLabel" runat="server" Text="Gender"></asp:Label>
                <br />
                <asp:Label ID="SummaryGender" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="SummaryEmailLabel" runat="server" Text="Email"></asp:Label>
                <br />
                <asp:Label ID="SummaryEmail" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="SummaryContactLabel" runat="server" Text="Contact"></asp:Label>
                <br />
                <asp:Label ID="SummaryContact" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="FinishButton" runat="server" Text="Finish" OnClick="FinishButton_Click" />
            </asp:View>

            <asp:View ID="ConfirmationView" runat="server">
            </asp:View>

        </asp:MultiView>
    </form>
</body>
</html>
