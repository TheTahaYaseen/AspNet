<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelControlGeneration.aspx.cs" Inherits="Asp.Net.PanelControlGeneration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="MainForm" runat="server" class="auto-style1">
        <asp:Label ID="ControlsLabel" runat="server" ></asp:Label>
        <br />
        
        <asp:CheckBoxList ID="ControlsSelection" runat="server">
        </asp:CheckBoxList>
        <br /><br />
        
        <asp:Label ID="ControlsCountLabel" runat="server" ></asp:Label>
        <br />
        
        <asp:TextBox ID="ControlsCount" runat="server"></asp:TextBox>
        <asp:Button ID="GenerateButton" runat="server" OnClick="GenerateButton_Click" />
        <br /><br />

        <asp:Label ID="LabelControlsLabel" runat="server" ></asp:Label>
        <br />

        <asp:Panel ID="LabelsPanel" runat="server"></asp:Panel>
        <br /><br />
        

        <asp:Label ID="TextboxControlsLabel" runat="server" ></asp:Label>
        <br />

        <asp:Panel ID="TextboxesPanel" runat="server"></asp:Panel>
        <br /><br />

        <asp:Label ID="ButtonControlsLabel" runat="server" ></asp:Label>
        <br />

        <asp:Panel ID="ButtonsPanel" runat="server"></asp:Panel>
        <br /><br />

    </form>
</body>
</html>
