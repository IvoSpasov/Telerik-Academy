<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Main.aspx.cs" Inherits="_02_International_Company.Main" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="cphMain" runat="server">
    <ul>
        <li><asp:HyperLink runat="server" NavigateUrl="~/USA/USAHome.aspx">Toyota USA</asp:HyperLink></li>
        <li><asp:HyperLink runat="server" NavigateUrl="~/UK/UKHome.aspx">Toyota UK</asp:HyperLink></li>
    </ul>
</asp:Content>
