<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_06_EmployeesWithListView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="lvEmployees" runat="server" ItemType="Northwind.Data.Employee">
                <LayoutTemplate>
                    <h3>Employee names:</h3>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <div>
                        <%#: Item.FirstName %>
                    </div>
                </ItemTemplate>
            </asp:ListView>

            <asp:DataPager ID="dpEmployees" runat="server"
                PagedControlID="lvEmployees" PageSize="3"
                QueryStringField="page">
                <Fields>
                    <asp:NextPreviousPagerField ShowFirstPageButton="true"
                        ShowNextPageButton="false" ShowPreviousPageButton="false"/>
                    <asp:NumericPagerField />
                </Fields>
            </asp:DataPager>
        </div>
    </form>
</body>
</html>
