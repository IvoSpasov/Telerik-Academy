<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="_01_HTMLRandomNumbers.RandomNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random numbers generator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Random numbers generator</h2>
            <label id="LabelLowRange" for="TextLowRange" runat="server">Low range value</label>
            <input type="text" id="TextLowRange" runat="server" />
            <br />
            <label for="TextHighRange">High range value</label>
            <input type="text" id="TextHighRange" runat="server" />
            <br />
            <input type="button" id="ButtonGenerate" value="Generate" runat="server" onserverclick="ButtonGenerate_ServerClick"/>
            <br />
            <label id="LabelResult" runat="server"></label>
        </div>
    </form>
</body>
</html>
