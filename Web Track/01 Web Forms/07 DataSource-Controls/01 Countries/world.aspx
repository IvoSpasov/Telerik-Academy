<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="World.aspx.cs" Inherits="_01_Countries.world" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:EntityDataSource ID="EntityDataSourceContinents" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableFlattening="False" EntitySetName="Continents">
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableFlattening="False" EntitySetName="Countries"
        Where="it.ContinentId=@ContID">
        <WhereParameters>
            <asp:ControlParameter ControlID="ListBoxContinents"
                Name="ContID" Type="Int32" />
        </WhereParameters>
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server"
        ConnectionString="name=WorldEntities" DefaultContainerName="WorldEntities"
        EnableFlattening="False" EntitySetName="Towns"
        Include="Country"
        Where="it.CountryId=@CountrID">
        <WhereParameters>
            <asp:ControlParameter ControlID="GridViewCountries"
                Name="CountrID" Type="Int32" />
        </WhereParameters>
    </asp:EntityDataSource>

    <form id="form1" runat="server">
        <asp:ListBox ID="ListBoxContinents" runat="server"
            DataSourceID="EntityDataSourceContinents"
            DataTextField="Name" DataValueField="ContinentId"
            Rows="5" AutoPostBack="true">

        </asp:ListBox>
        <br />
        <br />

        <asp:GridView ID="GridViewCountries" runat="server"
            AutoGenerateColumns="False" DataKeyNames="CountryId"
            DataSourceID="EntityDataSourceCountries"
            AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Country Name" SortExpression="Name" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="Poulation" HeaderText="Poulation" SortExpression="Poulation" />
            </Columns>
        </asp:GridView>

        <asp:ListView ID="ListViewTowns" runat="server" 
            DataKeyNames="TownId" DataSourceID="EntityDataSourceTowns"
            ItemType="_01_Countries.Town">
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="">
                </div>
            </LayoutTemplate>
            <%--            <AlternatingItemTemplate>
                            <span style="">TownId:
                            <asp:Label ID="TownIdLabel" runat="server" Text='<%# Eval("TownId") %>' />
                                <br />
                                Name:
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                                <br />
                                Population:
                            <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                                <br />
                                CountryId:
                            <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                                <br />
                                Country:
                            <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                                <br />
                                <br />
                            </span>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <span style="">TownId:
                            <asp:Label ID="TownIdLabel1" runat="server" Text='<%# Eval("TownId") %>' />
                                <br />
                                Name:
                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                <br />
                                Population:
                            <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                                <br />
                                CountryId:
                            <asp:TextBox ID="CountryIdTextBox" runat="server" Text='<%# Bind("CountryId") %>' />
                                <br />
                                Country:
                            <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                <br />
                                <br />
                            </span>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <span>No data was returned.</span>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <span style="">TownId:
                            <asp:TextBox ID="TownIdTextBox" runat="server" Text='<%# Bind("TownId") %>' />
                                <br />
                                Name:
                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                <br />
                                Population:
                            <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                                <br />
                                CountryId:
                            <asp:TextBox ID="CountryIdTextBox" runat="server" Text='<%# Bind("CountryId") %>' />
                                <br />
                                Country:
                            <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                <br />
                                <br />
                            </span>
                        </InsertItemTemplate>--%>
            <ItemTemplate>
                <span style="">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%#: Item.Name %>' />
                    <br />
                    Population:
                <asp:Label ID="PopulationLabel" runat="server" Text='<%#: Item.Population %>' />
                    <br />
                    Country:
                <asp:Label ID="CountryLabel" runat="server" Text='<%#: Item.Country.Name %>' /> <%--Eval("Country.Name")--%>
                    <br />
                    <br />
                </span>
            </ItemTemplate>
            <%--      <SelectedItemTemplate>
                <span style="">
                    Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    Population:
                <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    <br />
                    Country:
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                    <br />
                    <br />
                </span>
            </SelectedItemTemplate>--%>
        </asp:ListView>



    </form>
</body>
</html>
