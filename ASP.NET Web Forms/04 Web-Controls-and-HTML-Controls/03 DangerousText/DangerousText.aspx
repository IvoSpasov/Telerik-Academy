<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangerousText.aspx.cs" Inherits="_03_DangerousText.DangerousText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxInput" runat="server">&lt;h2&gt;Heading&lt;/h2&gt;</asp:TextBox>
            <br />
            <asp:Button ID="ButtonShowResult" runat="server" OnClick="ButtonShowResult_Click" Text="Show Text"/>
            <br />
            <strong>Safe text here</strong>
            <br />
            <asp:TextBox ID="TextBoxOutput" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
