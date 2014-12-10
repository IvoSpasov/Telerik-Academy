<%@ Page Title="Personal Info" Language="C#" MasterPageFile="~/UserProfile.Master" 
    AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="_01_UserProfile.PersonalInfo" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="cphMain" runat="server">
    <h3>Personal Info Page</h3>
    <ul>
        <li>
            First Name: Ivan
        </li>
        <li>
            Last Name: Petrov
        </li>
        <li>
            Students Number: 1234
        </li>
        <li>
            email: ivanpetrov@domain.com
        </li>
        <li>
            City: Sofia
        </li>
    </ul>
</asp:Content>
