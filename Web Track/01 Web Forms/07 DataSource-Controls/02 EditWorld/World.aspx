<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="World.aspx.cs" Inherits="_02_EditWorld.World" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:EntityDataSource ID="EntityDataSourceContinents" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableDelete="True" EnableFlattening="False" EnableInsert="True"
        EnableUpdate="True" EntitySetName="Continents">
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableDelete="True" EnableFlattening="False" EnableInsert="True"
        EnableUpdate="True" EntitySetName="Countries"
        Include="Continent">
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableDelete="True" EnableFlattening="False" EnableInsert="True"
        EnableUpdate="True" EntitySetName="Towns"
        Include="Country">
    </asp:EntityDataSource>

    <form id="form1" runat="server">
        <h2>Continents</h2>
        <asp:ListView ID="ListViewContinents" runat="server"
            DataSourceID="EntityDataSourceContinents" DataKeyNames="ContinentId"
            InsertItemPosition="LastItem" ItemType="_02_EditWorld.Continent">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server"></th>
                                    <th runat="server">Continent Name</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <%--<AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="ContinentIdLabel" runat="server" Text='<%# Eval("ContinentId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountriesLabel" runat="server" Text='<%# Eval("Countries") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>--%>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <h3>Insert new continent</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelContiName" runat="server">Name</asp:Label>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%#: Item.Name %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <%--<SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="ContinentIdLabel" runat="server" Text='<%# Eval("ContinentId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountriesLabel" runat="server" Text='<%# Eval("Countries") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>--%>
        </asp:ListView>

        <h2>Countries</h2>
        <asp:ListView ID="ListViewCountries" runat="server"
            DataSourceID="EntityDataSourceCountries"
            DataKeyNames="CountryId" InsertItemPosition="LastItem"
            ItemType="_02_EditWorld.Country">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server"></th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Language</th>
                                    <th runat="server">Population</th>
                                    <th runat="server">Continent</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <%--            <AlternatingItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                </td>
                                <td>
                                    <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="LanguageLabel" runat="server" Text='<%# Eval("Language") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="PoulationLabel" runat="server" Text='<%# Eval("Poulation") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="ContinentIdLabel" runat="server" Text='<%# Eval("ContinentId") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="ContinentLabel" runat="server" Text='<%# Eval("Continent") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="TownsLabel" runat="server" Text='<%# Eval("Towns") %>' />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>--%>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LanguageTextBox" runat="server" Text='<%#: BindItem.Language %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PoulationTextBox" runat="server" Text='<%#: BindItem.Poulation %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListContinent" runat="server"
                            DataSourceID="EntityDataSourceContinents"
                            DataValueField="ContinentId"
                            DataTextField="Name"
                            SelectedValue="<%#: BindItem.ContinentId %>">
                        </asp:DropDownList>
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#: BindItem.Language %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%#: BindItem.Poulation %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListContinent" runat="server"
                            DataSourceID="EntityDataSourceContinents"
                            DataValueField="ContinentId"
                            DataTextField="Name"
                            SelectedValue="<%#: BindItem.ContinentId %>">
                        </asp:DropDownList>
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%#: Item.Name %>' />
                    </td>
                    <td>
                        <asp:Label ID="LanguageLabel" runat="server" Text='<%#: Item.Language %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%#: Item.Poulation %>' />
                    </td>
                    <td>
                        <asp:Label ID="ContinentLabel" runat="server" Text='<%#: (Item.Continent != null) ? Item.Continent.Name : "" %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <%--<SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LanguageLabel" runat="server" Text='<%# Eval("Language") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PoulationLabel" runat="server" Text='<%# Eval("Poulation") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ContinentIdLabel" runat="server" Text='<%# Eval("ContinentId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ContinentLabel" runat="server" Text='<%# Eval("Continent") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TownsLabel" runat="server" Text='<%# Eval("Towns") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>--%>
        </asp:ListView>

        <h2>Towns</h2>
        <asp:ListView ID="ListViewTowns" runat="server"
            DataSourceID="EntityDataSourceTowns"
            DataKeyNames="TownId" InsertItemPosition="LastItem"
            ItemType="_02_EditWorld.Town">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="">
                                <tr runat="server" style="">
                                    <th runat="server"></th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Population</th>
                                    <th runat="server">Country</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <%--<AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="TownIdLabel" runat="server" Text='<%# Eval("TownId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>--%>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%#: BindItem.Population %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListCountries" runat="server"
                            DataSourceID="EntityDataSourceCountries"
                            DataValueField="CountryId"
                            DataTextField="Name"
                            SelectedValue="<%#: BindItem.CountryId %>">
                        </asp:DropDownList>
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%#: BindItem.Name %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%#: BindItem.Population %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListCountries" runat="server"
                            DataSourceID="EntityDataSourceCountries"
                            DataValueField="CountryId"
                            DataTextField="Name"
                            SelectedValue="<%#: BindItem.CountryId %>">
                        </asp:DropDownList>
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%#: Item.Name %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%#: Item.Population %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%#: Item.Country.Name %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="TownIdLabel" runat="server" Text='<%# Eval("TownId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
