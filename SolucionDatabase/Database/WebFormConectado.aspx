<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormConectado.aspx.cs" Inherits="Database.WebFormConectado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="conectar" ID="btnConectar" runat="server" OnClick="btnConectar_Click"/>
        <asp:DropDownList ID="dropdownClientes" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnVer" runat="server" Text="Ver" OnClick="btnVer_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ID:  "></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Territorio:   "></asp:Label>
        <asp:TextBox ID="txtTerritorio" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Store:   "></asp:Label>
        <asp:TextBox ID="txtStore" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Fecha:   "></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Cuenta:   "></asp:Label>
        <asp:TextBox ID="txtCuenta" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
