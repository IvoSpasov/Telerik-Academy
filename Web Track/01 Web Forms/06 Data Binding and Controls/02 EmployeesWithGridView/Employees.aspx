<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_02_EmployeesWithGridView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvEmployees" runat="server" 
                AutoGenerateColumns="false"
                AllowPaging="true">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:HyperLinkField Text="Details" 
                        DataNavigateUrlFields="EmployeeID"
                        DataNavigateUrlFormatString="EmpDetails.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
