<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="_02_EmployeesWithGridView.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="dvEmployees" runat="server"
                AutoGenerateRows="true">
            </asp:DetailsView>

            <br />
            <asp:Button ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        </div>
    </form>
</body>
</html>
