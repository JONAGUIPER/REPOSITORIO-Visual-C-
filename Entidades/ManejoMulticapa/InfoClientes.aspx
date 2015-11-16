<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfoClientes.aspx.cs" Inherits="ManejoMulticapa.InfoClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Clientes:"></asp:Label>
        <asp:DropDownList ID="dbClientes" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Datos:"></asp:Label>
        <asp:DetailsView ID="dvCliente" runat="server" Height="50px" Width="125px">
        </asp:DetailsView>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Pedidos"></asp:Label>
        <asp:GridView ID="gvPedidos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
