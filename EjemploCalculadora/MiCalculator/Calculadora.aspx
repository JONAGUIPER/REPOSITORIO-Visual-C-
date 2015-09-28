<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="MiCalculator.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNumero1" runat="server" />
            <br />
            <asp:TextBox ID="txtNumero2" runat="server" />
            <br />
            <asp:Button ID="btnSuma" Text="+" runat="server" OnClick="Opera"/>
            <asp:Button ID="btnResta" Text="-" runat="server" OnClick="Opera"/>
            <asp:Button ID="btnMultiplicacion" Text="x" runat="server" OnClick="Opera" />
            <asp:Button ID="btnDivision" Text="/" runat="server" OnClick="Opera"/>
            <br />
            <asp:TextBox ID="txtResultado" runat="server" />
        </div>
    </form>
</body>
</html>
