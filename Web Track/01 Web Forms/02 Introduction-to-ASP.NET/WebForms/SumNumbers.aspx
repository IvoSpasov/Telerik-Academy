<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumNumbers.aspx.cs" Inherits="WebForms.SumNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="First">First number</label>
        <asp:TextBox ID="First" runat="server"></asp:TextBox>
        <br />
        <label for="Second">Second number</label>
        <asp:TextBox ID="Second" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Sum" runat="server" Text="Get Sum" OnClick="Sum_Click" />
        <br />
        <label for="Result">Result</label>
        <asp:TextBox ID="Result" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
