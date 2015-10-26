<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Database.Pedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnConectar" runat="server" OnClick="btnConectar_Click" style="height: 26px" Text="Conectar" />
        <asp:DropDownList ID="DropDownIds" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnVer" runat="server" Text="Ver Pedidos" />
    
    </div>
        <asp:GridView ID="gridPedidos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
