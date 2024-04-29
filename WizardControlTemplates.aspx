<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardControlTemplates.aspx.cs" Inherits="Asp.Net.WizardControlTemplates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Wizard ID="MainWizard" runat="server">
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" UseSubmitBehavior="false" />
                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" OnClientClick="return confirm('Are you sure you want to submit?');" />
            </FinishNavigationTemplate>
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" OnClientClick="return confirm('Are you sure you want to proceed?');" />
            </StartNavigationTemplate>
            <StepNavigationTemplate>
                <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" />
            </StepNavigationTemplate>
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    <asp:TextBox ID="Step1Box" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    <asp:TextBox ID="Step2Box" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 3">
                    <asp:TextBox ID="Step3Box" runat="server"></asp:TextBox>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </form>
</body>
</html>
