<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="PageNavigation.aspx.cs" Inherits="Asp.Net.PageNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        function OpenNewWindow() {
            var Opinion = document.getElementById("OpinionInput").value;
            window.open("OpinionShow.aspx?Opinion="+Opinion, "_self", "location=no,resizable=no", false);
        }
    </script>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:TextBox ID="OpinionInput" runat="server"></asp:TextBox>
        
        <asp:HyperLink ID="Hyperlink" runat="server"></asp:HyperLink>
        <br/><br/>
        <asp:Button ID="ResponseRedirectButton" runat="server" OnClick="ResponseRedirectButton_Click" />
        <br/><br/>

        <br/>
        <asp:Button ID="ServerTransferButton" runat="server" OnClick="ServerTransferButton_Click" />
        <br/>
        <asp:Button ID="ServerExternalTransferButton" runat="server" OnClick="ServerExternalTransferButton_Click" />
        <br/><br/>

        <br/>
        <asp:Button ID="ServerExecuteButton" runat="server" OnClick="ServerExecuteButton_Click"/>
        <br/>
        <asp:Button ID="ServerExternalExecuteButton" runat="server" OnClick="ServerExternalExecuteButton_Click"/>
        <br/><br/>

        <asp:Button ID="CrossPagePostButton" PostBackUrl="~/OpinionShow.aspx" runat="server" />
        <br/><br/>

        <input id="OpenNewWindowButton" type="button" value="Open New Window Using JS" onclick="OpenNewWindow()" />
        <br/><br/>

        <asp:Button ID="OpenNewWindowUsingCodeButton" runat="server" OnClick="OpenNewWindowUsingCodeButton_Click" />
        <br/><br/>

        <asp:Button ID="QueryStringInformationRetrieval" runat="server" OnClick="QueryStringInformationRetrieval_Click"/>
        <br/><br/>

        <asp:Button ID="CookieCreateButton" runat="server" OnClick="CookieCreateButton_Click" />
        <br/><br/>

        <asp:Button ID="ApplicationCreateButton" runat="server" OnClick="ApplicationCreateButton_Click" />
        <br/><br/>

        <asp:Button ID="SessionCreateButton" runat="server" OnClick="SessionCreateButton_Click" />
        <br/><br />

        <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />

    </form>
</body>
</html>
