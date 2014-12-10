<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="_02_WebRandomNumbers.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random numbers generator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Random numbers generator</h2>
            <asp:Label ID="LabelLowRange" runat="server">Low range</asp:Label>
            <asp:TextBox ID="TextBoxLowRange" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelHighRange" runat="server">High range</asp:Label>
            <asp:TextBox ID="TextBoxHighRange" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonGenerate" runat="server" OnClick="ButtonGenerate_Click" Text="Generate" />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
