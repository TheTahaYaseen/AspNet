<%@ Page Language="C#" Trace="false" AutoEventWireup="true" CodeBehind="FirstCounter.aspx.cs" Inherits="Asp.Net.FirstCounter" %>

<!DOCTYPE html>

 <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:AdRotator ID="AdRotator1" runat="server" />
        <asp:TextBox ID="Counter" runat="server" ClientIDMode="Static"></asp:TextBox>
        <asp:Button ID="Count" runat="server" OnClick="Count_Click" Text="Count" />
    
        <%--<h3>Html Input</h3>--%>
        <%--<input type="text" id="HtmlInput" />--%> <%--It does not retain its value due to not having runat="server"--%>
        <%--<input type="text" id="HtmlInput" runat="server" />--%> <%--It retains its value due to runat="server"--%>

        <%--<h3>Asp .Net Input</h3>--%>
        <%--<asp:TextBox ID="AspNetControl" runat="server" ClientIDMode="Static"></asp:TextBox>--%> <%--It retains its value due to runat="server"--%>

        <%--<br />--%>
        <%--<br />--%>

        <%--<asp:Button ID="Test" runat="server" OnClick="Test_Click" Text="Test" />--%>
    </form>
</body>
</html>
