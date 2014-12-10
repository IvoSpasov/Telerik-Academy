<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="_01_RegisterForm.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label">Username</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Password</asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label">Confirm Password</asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
            ControlToCompare="TextBox2"
            ControlToValidate="TextBox3" Display="Dynamic"
            ErrorMessage="Passwords don't match!" ForeColor="Red" EnableClientScript="False">
        </asp:CompareValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label">First Name</asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label">Last Name</asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label">Age</asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox6"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server"
            ErrorMessage="RangeValidator" Text="Age must be between 18 and 81"
            ControlToValidate="TextBox6" MaximumValue="81" MinimumValue="18"
            ForeColor="Red" EnableClientScript="False" Type="Integer">
        </asp:RangeValidator>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label">Email</asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox7"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            ID="RegularExpressionValidatorEmail"
            runat="server" ForeColor="Red" Display="Dynamic"
            ErrorMessage="Email address is incorrect!"
            ControlToValidate="TextBox7" EnableClientScript="False"
            ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}">
        </asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Label">Local Address</asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox8"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Label">Phone</asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
            ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox9"
            Text="Required Field" ForeColor="Red" EnableClientScript="False">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Label">I Accept</asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
