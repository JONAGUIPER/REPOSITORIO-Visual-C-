<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ModeloPorCapas.Vistas.Clientes" %>

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
        <br />
        <asp:GridView ID="gvClientes" runat="server" OnSelectedIndexChanged="gvClientes_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblEstado" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
