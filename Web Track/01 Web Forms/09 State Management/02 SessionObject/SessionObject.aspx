<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionObject.aspx.cs" Inherits="_02_SessionObject.SessionObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        <br />
        <asp:Label ID="LabelOutput" runat="server"></asp:Label>
    </form>
</body>
</html>
