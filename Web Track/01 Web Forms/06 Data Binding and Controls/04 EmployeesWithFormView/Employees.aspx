<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_04_EmployeesWithFormView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="fvEmployees" runat="server"
                AllowPaging="true" OnPageIndexChanging="fvEmployees_PageIndexChanging">
                <ItemTemplate>
                    <h3><%#: Eval("FirstName") + " " + Eval("LastName") %></h3>
                    <table border="0">
                        <tr>
                            <td>Title:</td>
                            <td><%#: Eval("Title") %></td>
                        </tr>
                        <tr>
                            <td>Birth Date:</td>
                            <td><%#: Eval("BirthDate") %></td>
                        </tr>
                        <tr>
                            <td>Address:</td>
                            <td><%#: Eval("Address") %></td>
                        </tr>
                        <tr>
                            <td>City:</td>
                            <td><%#: Eval("City") %></td>
                        </tr>
                        <tr>
                            <td>Postal Code:</td>
                            <td><%#: Eval("PostalCode") %></td>
                        </tr>
                        <tr>
                            <td>Country:</td>
                            <td><%#: Eval("Country") %></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
