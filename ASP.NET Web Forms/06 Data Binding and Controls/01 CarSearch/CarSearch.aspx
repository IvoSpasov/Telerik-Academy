<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarSearch.aspx.cs" Inherits="_01_CarSearch.CarSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelProducer" runat="server">Manufacturer</asp:Label>
            <asp:DropDownList ID="ddlProducer" runat="server"
                AutoPostBack="true"
                DataTextField="Name"
                OnSelectedIndexChanged="ddlProducer_SelectedIndexChanged">
            </asp:DropDownList>
            <br />

            <asp:Label ID="LabelModel" runat="server">Model</asp:Label>
            <asp:DropDownList ID="ddlModel" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="LabelExtras" runat="server">Extras</asp:Label>
            <asp:CheckBoxList ID="cblExtras" runat="server"></asp:CheckBoxList>
            <br />

            <asp:Label ID="LabelEngines" runat="server">Engines</asp:Label>
            <asp:RadioButtonList ID="rblEngines" runat="server"></asp:RadioButtonList>
            <br />

            <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
            <br />
            
            <asp:Literal ID="LiteralResult" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
