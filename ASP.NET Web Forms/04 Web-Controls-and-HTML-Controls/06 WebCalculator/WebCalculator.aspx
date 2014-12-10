<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCalculator.aspx.cs" Inherits="_06_WebCalculator.WebCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxOutput" runat="server">0</asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="1" CommandName="1" OnCommand="OnCommand" />
            <asp:Button ID="Button2" runat="server" Text="2" CommandName="2" OnCommand="OnCommand" />
            <asp:Button ID="Button3" runat="server" Text="3" CommandName="3" OnCommand="OnCommand" />
            <asp:Button ID="ButtonAdd" runat="server" Text="+" CommandName="+" OnCommand="OnCommand" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="4" CommandName="4" OnCommand="OnCommand" />
            <asp:Button ID="Button5" runat="server" Text="5" CommandName="5" OnCommand="OnCommand" />
            <asp:Button ID="Button6" runat="server" Text="6" CommandName="6" OnCommand="OnCommand" />
            <asp:Button ID="ButtonSubtract" runat="server" Text="-" CommandName="-" OnCommand="OnCommand" />
            <br />
            <asp:Button ID="Button7" runat="server" Text="7" CommandName="7" OnCommand="OnCommand" />
            <asp:Button ID="Button8" runat="server" Text="8" CommandName="8" OnCommand="OnCommand" />
            <asp:Button ID="Button9" runat="server" Text="9" CommandName="9" OnCommand="OnCommand" />
            <asp:Button ID="ButtonMultiply" runat="server" Text="*" CommandName="*" OnCommand="OnCommand" />
            <br />
            <asp:Button ID="ButtonClear" runat="server" Text="Clear" CommandName="Clear" OnCommand="OnCommand" />
            <asp:Button ID="Button0" runat="server" Text="0" CommandName="0" OnCommand="OnCommand" />
            <asp:Button ID="ButtonDivide" runat="server" Text="/" CommandName="/" OnCommand="OnCommand" />
            <asp:Button ID="ButtonSqrt" runat="server" Text="&radic;" CommandName="Sqrt" OnCommand="OnCommand" />
            <br />
            <asp:Button ID="ButtonEquals" runat="server" Text="=" CommandName="=" OnCommand="OnCommand" />
        </div>
    </form>
</body>
</html>
