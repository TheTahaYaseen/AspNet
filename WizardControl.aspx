<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardControl.aspx.cs" Inherits="Asp.Net.WizardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <asp:CheckBox ID="CancelNavigation" Text="Cancel Navigation" runat="server" />
            <asp:Wizard ID="MainWizard" runat="server" Height="317px" OnFinishButtonClick="MainWizard_FinishButtonClick" OnNextButtonClick="MainWizard_NextButtonClick" Width="332px" OnActiveStepChanged="MainWizard_ActiveStepChanged" OnCancelButtonClick="MainWizard_CancelButtonClick" OnPreviousButtonClick="MainWizard_PreviousButtonClick" OnSideBarButtonClick="MainWizard_SideBarButtonClick">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Personal">
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
                        
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Contact">
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
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Summary">
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
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
