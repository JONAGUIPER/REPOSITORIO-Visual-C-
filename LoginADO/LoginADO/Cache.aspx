<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cache.aspx.cs" Inherits="LoginADO.Cache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnVerClientes" runat="server" Text="Ver Clientes" OnClick="btnVerClientes_Click" />
        <asp:GridView ID="gvClientes" runat="server"></asp:GridView>
        <asp:LinkButton ID="IrCacheTest" runat="server" PostBackUrl="~/CacheTest.aspx">Ir a CacheTest</asp:LinkButton>
    </div>
    </form>
</body>
</html>
