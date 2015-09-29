<%@ Page Language="C#" AutoEventWireup="true" Trace="true" CodeBehind="CalculatorTecla.aspx.cs" Inherits="CalculadoraTeclas.CalculatorTecla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtDatos" runat="server" />
        <br />
        <asp:Button Text="1" runat="server" OnClick="EscribirPantalla"/>
        <asp:Button Text="2" runat="server" OnClick="EscribirPantalla"/>
        <asp:Button Text="3" runat="server" OnClick="EscribirPantalla"/>
        <asp:Button Text="+" runat="server" OnClick="Operacion"/>
        <br />

        <asp:Button Text="4" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="5" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="6" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="-" runat="server"  OnClick="Operacion"/>
        <br />

        <asp:Button Text="7" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="8" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="9" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="*" runat="server"  OnClick="Operacion"/>
        <br />

        <asp:Button Text="0" width="45px" runat="server"  OnClick="EscribirPantalla"/>
        <asp:Button Text="." runat="server" OnClick="EscribirPantalla"/>
        <asp:Button Text="/" runat="server" OnClick="Operacion"/>
        <br />
        <asp:Button Text="Enter" width="80px" runat="server" OnClick="Enter"/>
        


    </div>
    </form>
</body>
</html>
