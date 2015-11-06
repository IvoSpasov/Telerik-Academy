<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloPage.aspx.cs" Inherits="_01_HelloPage.HelloPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Enter Your Name:</b>
            <asp:TextBox ID="TextBoxNameInput" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonPrintName" runat="server" Text="Print" OnClick="ButtonPrintName_Click" />
            <br />
            <br />            
            <asp:Label ID="LabelNameOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
