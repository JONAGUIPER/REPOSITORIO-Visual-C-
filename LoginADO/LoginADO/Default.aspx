<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginADO.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Label ID="lblWelcome" runat="server" Text="Hola: "></asp:Label>
    
        <h1>
            <asp:Label ID="Label1" runat="server" Text="SELECCIONE QUE DESEA HACER"></asp:Label>
        </h1>
&nbsp;<br />
        
            <asp:LinkButton ID="lkbClientes" runat="server" PostBackUrl="~/Clientes.aspx">Clientes</asp:LinkButton>
        
        <br />
        <asp:LinkButton ID="lkbPedidos" runat="server" PostBackUrl="~/Pedidos.aspx">Pedidos</asp:LinkButton>
        <br />
        <asp:LinkButton ID="lkbTiendas" runat="server" PostBackUrl="~/Tiendas.aspx">Tiendas</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
