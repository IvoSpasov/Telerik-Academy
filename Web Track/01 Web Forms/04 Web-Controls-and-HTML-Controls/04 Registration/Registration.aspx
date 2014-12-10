<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_04_Registration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelFirstName" runat="server">First Name</asp:Label>
            <asp:TextBox ID="TextBoxFirstName" runat="server">Ivan</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="TextBoxFirstName" ErrorMessage="First name is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelLastName" runat="server">Last Name</asp:Label>
            <asp:TextBox ID="TextBoxLastName" runat="server">Petrov</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="TextBoxLastName" ErrorMessage="Last name is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelFacultyNumber" runat="server">Faculty Number</asp:Label>
            <asp:TextBox ID="TextBoxFacultyNumber" runat="server">101206530</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFacultyNumber" runat="server" ControlToValidate="TextBoxFacultyNumber" ErrorMessage="Faculty number is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelUniversity" runat="server">University</asp:Label>
            <asp:DropDownList ID="ddlUniversity" runat="server">
                <asp:ListItem Value="Oxford">Oxford</asp:ListItem>
                <asp:ListItem Value="MIT">MIT</asp:ListItem>
                <asp:ListItem Value="Berkeley">Berkeley</asp:ListItem>
                <asp:ListItem Value="Stanford">Stanford</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelSpecialty" runat="server">Specialty</asp:Label>
            <asp:DropDownList ID="ddlSpecialty" runat="server">
                <asp:ListItem Value="Computer Science">Computer Science</asp:ListItem>
                <asp:ListItem Value="Electronics">Electronics</asp:ListItem>
                <asp:ListItem Value="Telecommunications">Telecommunications</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelCourses" runat="server">Courses</asp:Label>
            <asp:CheckBoxList ID="cblCourses" runat="server">
                <asp:ListItem Value="C# part 1">C# part 1</asp:ListItem>
                <asp:ListItem Value="C# part 2">C# part 2</asp:ListItem>
                <asp:ListItem Value="C# OOP">C# OOP</asp:ListItem>
                <asp:ListItem Value="HTML">HTML</asp:ListItem>
                <asp:ListItem Value="CSS">CSS</asp:ListItem>
                <asp:ListItem Value="JavaScript">JavaScript</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
